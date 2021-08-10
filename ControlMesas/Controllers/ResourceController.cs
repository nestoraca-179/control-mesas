using ControlMesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ControlMesas.Controllers
{
    public class ResourceController : ApiController
    {
        private ControlMesasContext db = new ControlMesasContext();

        [HttpGet]
        [Route("api/Resource/GetTablesZone/{id}")]
        public List<Mesas> getTablesByZone(int id)
        {
            return db.Mesas.Where(m => m.IDZona == id).ToList();
        }

        [HttpGet]
        [Route("api/Resource/GetArtsId/{id}")]
        public List<Articulos> getArtsById(int id)
        {
            return db.Articulos.Where(a => a.IDCategoria == id).ToList();
        }

        [HttpGet]
        [Route("api/Resource/GetItemsTable/{id}")]
        public List<ItemMesa> getItemsByMesa(int id)
        {
            var results = from m in db.MesasItems.Where(i => i.IDMesa == id)
                          join a in db.Articulos on m.IDArticulo equals a.ID
                          select new ItemMesa
                          {
                              ID = m.IDMesaItem.ToString(),
                              Nombre = a.Nombre,
                              Cantidad = m.Cantidad.Value,
                              Precio = m.TotalArticulo.Value
                          };

            return results.ToList();
        }

        [HttpPost]
        [Route("api/Resource/InsertItem/")]
        public ControlMesasResponse insertItem(MesasItems item)
        {
            ControlMesasResponse response = new ControlMesasResponse();

            item.FechaHora = DateTime.Now;

            try
            {
                db.MesasItems.Add(item);
                db.SaveChanges();

                int id = db.MesasItems.AsEnumerable().Last().IDMesaItem;

                response.Estatus = "OK";
                response.Resultado = id;
            }
            catch (Exception ex)
            {
                response.Estatus = "ERROR";
                response.Mensaje = ex.Message;
            }

            return response;
        }
    }
}