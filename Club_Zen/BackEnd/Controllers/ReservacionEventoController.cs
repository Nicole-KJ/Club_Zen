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
    public class ReservacionEventoController : ControllerBase
    {

        private IReservacionEventoDAL reservacionEventoDAL;
        
        
        #region Constructor
        public ReservacionEventoController()
        {
            reservacionEventoDAL = new ReservacionEventoDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<ReservacionEventoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.ReservacionEvento> reservacionEventos = reservacionEventoDAL.GetAll();


            return new JsonResult(reservacionEventos);
        }

        // GET api/<ReservacionEventoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.ReservacionEvento reservacionEvento;
            reservacionEvento = reservacionEventoDAL.Get(id);


            return new JsonResult(reservacionEvento);

        }
        #endregion


        #region Agregar
        // POST api/<ReservacionEventoController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.ReservacionEvento reservacionEvento)
        {
            reservacionEventoDAL.Add(reservacionEvento);
            return new JsonResult(reservacionEvento);

        }

        #endregion


        #region Modificar
        // PUT api/<ReservacionEventoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.ReservacionEvento reservacionEvento)
        {

            reservacionEventoDAL.Update(reservacionEvento);
            return new JsonResult(reservacionEvento);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<ReservacionEventoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.ReservacionEvento reservacionEvento = new Entities.ReservacionEvento { IdReservacionEvento = id };
            reservacionEventoDAL.Remove(reservacionEvento);

            return new  JsonResult(reservacionEvento);


        }


        #endregion
    }
}
