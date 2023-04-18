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
    public class ReservacionRanchitoController : ControllerBase
    {

        private IReservacionRanchitoDAL reservacionRanchitoDAL;
        
        
        #region Constructor
        public ReservacionRanchitoController()
        {
            reservacionRanchitoDAL = new ReservacionRanchitoDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<ReservacionRanchitoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.ReservacionRanchito> reservacionRanchitos = reservacionRanchitoDAL.GetAll();


            return new JsonResult(reservacionRanchitos);
        }

        // GET api/<ReservacionRanchitoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.ReservacionRanchito reservacionRanchito;
            reservacionRanchito = reservacionRanchitoDAL.Get(id);


            return new JsonResult(reservacionRanchito);

        }
        #endregion


        #region Agregar
        // POST api/<ReservacionRanchitoController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.ReservacionRanchito reservacionRanchito)
        {
            reservacionRanchitoDAL.Add(reservacionRanchito);
            return new JsonResult(reservacionRanchito);
                
        }

        #endregion


        #region Modificar
        // PUT api/<ReservacionRanchitoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.ReservacionRanchito reservacionRanchito)
        {

            reservacionRanchitoDAL.Update(reservacionRanchito);
            return new JsonResult(reservacionRanchito);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<ReservacionRanchitoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.ReservacionRanchito reservacionRanchito = new Entities.ReservacionRanchito { IdReservacionRanchito = id };
            reservacionRanchitoDAL.Remove(reservacionRanchito);

            return new  JsonResult(reservacionRanchito);


        }


        #endregion
    }
}
