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
    public class ReservacionTennisController : ControllerBase
    {

        private IReservacionTennisDAL reservacionTennisDAL;
        
        
        #region Constructor
        public ReservacionTennisController()
        {
            reservacionTennisDAL = new ReservacionTennisDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<ReservacionTennisController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.ReservacionTennis> reservacionTennies = reservacionTennisDAL.GetAll();


            return new JsonResult(reservacionTennies);
        }

        // GET api/<ReservacionTennisController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.ReservacionTennis reservacionTennis;
            reservacionTennis = reservacionTennisDAL.Get(id);


            return new JsonResult(reservacionTennis);

        }
        #endregion


        #region Agregar
        // POST api/<ReservacionTennisController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.ReservacionTennis reservacionTennis)
        {
            reservacionTennisDAL.Add(reservacionTennis);
            return new JsonResult(reservacionTennis);

        }

        #endregion


        #region Modificar
        // PUT api/<ReservacionTennisController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.ReservacionTennis reservacionTennis)
        {

            reservacionTennisDAL.Update(reservacionTennis);
            return new JsonResult(reservacionTennis);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<ReservacionTennisController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.ReservacionTennis reservacionTennis = new Entities.ReservacionTennis { IdReservacionTennis = id };
            reservacionTennisDAL.Remove(reservacionTennis);

            return new  JsonResult(reservacionTennis);


        }


        #endregion
    }
}
