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
    public class ReservacionMesaController : ControllerBase
    {

        private IReservacionMesaDAL reservacionMesaDAL;
        
        
        #region Constructor
        public ReservacionMesaController()
        {
            reservacionMesaDAL = new ReservacionMesaDALImpl(new BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<ReservacionMesaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<ReservacionMesa> reservacionMesas = reservacionMesaDAL.GetAll();


            return new JsonResult(reservacionMesas);
        }

        // GET api/<ReservacionMesaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
         ReservacionMesa reservacionMesa;
            reservacionMesa = reservacionMesaDAL.Get(id);


            return new JsonResult(reservacionMesa);

        }
        #endregion


        #region Agregar
        // POST api/<ReservacionMesaController>
        [HttpPost]
        public JsonResult Post([FromBody] ReservacionMesa reservacionMesa)
        {
            reservacionMesaDAL.Add(reservacionMesa);
            return new JsonResult(reservacionMesa);

        }

        #endregion


        #region Modificar
        // PUT api/<ReservacionMesaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] ReservacionMesa reservacionMesa)
        {

            reservacionMesaDAL.Update(reservacionMesa);
            return new JsonResult(reservacionMesa);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<ReservacionMesaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            ReservacionMesa reservacionMesa = new ReservacionMesa { IdReservacionMesa = id };
            reservacionMesaDAL.Remove(reservacionMesa);

            return new  JsonResult(reservacionMesa);


        }


        #endregion
    }
}
