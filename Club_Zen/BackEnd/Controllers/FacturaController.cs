using DAL.Implementations;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using BackEnd;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private IFacturaDAL facturaDAL;
        
        
        #region Constructor
        public FacturaController()
        {
            facturaDAL = new FacturaDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<FacturaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.Factura> facturas = facturaDAL.GetAll();


            return new JsonResult(facturas);
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.Factura factura;
            factura = facturaDAL.Get(id);


            return new JsonResult(factura);

        }
        #endregion


        #region Agregar
        // POST api/<FacturaController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.Factura factura)
        {
            facturaDAL.Add(factura);
            return new JsonResult(factura);

        }

        #endregion


        #region Modificar
        // PUT api/<FacturaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.Factura factura)
        {

            facturaDAL.Update(factura);
            return new JsonResult(factura);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.Factura factura = new Entities.Factura { IdFactura = id };
            facturaDAL.Remove(factura);

            return new  JsonResult(factura);


        }


        #endregion
    }
}
