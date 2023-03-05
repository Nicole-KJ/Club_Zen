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
    public class LineaFacturaController : ControllerBase
    {

        private ILineaFacturaDAL lineaFacturaDAL;
        
        
        #region Constructor
        public LineaFacturaController()
        {
            lineaFacturaDAL = new LineaFacturaDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<LineaFacturaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.LineaFactura> lineafacturas = lineaFacturaDAL.GetAll();


            return new JsonResult(lineafacturas);
        }

        // GET api/<LineaFacturaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.LineaFactura lineafactura;
            lineafactura = lineaFacturaDAL.Get(id);


            return new JsonResult(lineafactura);

        }
        #endregion


        #region Agregar
        // POST api/<LineaFacturaController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.LineaFactura lineafactura)
        {
            lineaFacturaDAL.Add(lineafactura);
            return new JsonResult(lineafactura);

        }

        #endregion


        #region Modificar
        // PUT api/<LineaFacturaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.LineaFactura lineafactura)
        {

            lineaFacturaDAL.Update(lineafactura);
            return new JsonResult(lineafactura);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<LineaFacturaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.LineaFactura lineafactura = new Entities.LineaFactura { IdLinea = id };
            lineaFacturaDAL.Remove(lineafactura);

            return new  JsonResult(lineafactura);


        }


        #endregion
    }
}
