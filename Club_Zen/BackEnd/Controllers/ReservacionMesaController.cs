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
            reservacionMesaDAL = new ReservacionMesaDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<ReservacionMesaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.ReservacionMesa> reservacionMesas = reservacionMesaDAL.GetAll();


            return new JsonResult(reservacionMesas);
        }

        // GET api/<ReservacionMesaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.ReservacionMesa reservacionMesa;
            reservacionMesa = reservacionMesaDAL.Get(id);


            return new JsonResult(reservacionMesa);

        }
        #endregion


        #region Agregar
        // POST api/<ReservacionMesaController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.ReservacionMesa reservacionMesa)
        {
            reservacionMesaDAL.Add(reservacionMesa);
            return new JsonResult(reservacionMesa);

        }

        #endregion


        #region Modificar
        // PUT api/<ReservacionMesaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.ReservacionMesa reservacionMesa)
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
            Entities.ReservacionMesa reservacionMesa = new Entities.ReservacionMesa { IdReservacionMesa = id };
            reservacionMesaDAL.Remove(reservacionMesa);

            return new  JsonResult(reservacionMesa);


        }


        #endregion
    }
}
