using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using BackEnd;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetodoPagoController : ControllerBase
    {

        private IMetodoPagoDAL metodoPagoDAL;
        
        
        #region Constructor
        public MetodoPagoController()
        {
            metodoPagoDAL = new MetodoPagoDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<MetodoPagoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.MetodoPago> metodoPagos = metodoPagoDAL.GetAll();


            return new JsonResult(metodoPagos);
        }

        // GET api/<MetodoPagoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.MetodoPago metodoPago;
            metodoPago = metodoPagoDAL.Get(id);


            return new JsonResult(metodoPago);

        }
        #endregion


        #region Agregar
        // POST api/<MetodoPagoController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.MetodoPago metodoPago)
        {
            metodoPagoDAL.Add(metodoPago);
            return new JsonResult(metodoPago);

        }

        #endregion


        #region Modificar
        // PUT api/<MetodoPagoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.MetodoPago metodoPago)
        {

            metodoPagoDAL.Update(metodoPago);
            return new JsonResult(metodoPago);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<MetodoPagoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.MetodoPago metodoPago = new Entities.MetodoPago { IdMetodoPago = id };
            metodoPagoDAL.Remove(metodoPago);

            return new  JsonResult(metodoPago);


        }


        #endregion
    }
}
