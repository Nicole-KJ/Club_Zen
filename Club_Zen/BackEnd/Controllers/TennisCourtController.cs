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
    public class TennisCourtController : ControllerBase
    {

        private ITennisCourtDAL tennisCourtDAL;
        
        
        #region Constructor
        public TennisCourtController()
        {
            tennisCourtDAL = new TennisCourtDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<TennisCourtController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.TennisCourt> tennisCourts = tennisCourtDAL.GetAll();


            return new JsonResult(tennisCourts);
        }

        // GET api/<TennisCourtController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.TennisCourt tennisCourt;
            tennisCourt = tennisCourtDAL.Get(id);


            return new JsonResult(tennisCourt);

        }
        #endregion


        #region Agregar
        // POST api/<TennisCourtController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.TennisCourt tennisCourt)
        {
            tennisCourtDAL.Add(tennisCourt);
            return new JsonResult(tennisCourt);

        }

        #endregion


        #region Modificar
        // PUT api/<TennisCourtController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.TennisCourt tennisCourt)
        {

            tennisCourtDAL.Update(tennisCourt);
            return new JsonResult(tennisCourt);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<TennisCourtController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.TennisCourt tennisCourt = new Entities.TennisCourt { IdTennisCourt = id };
            tennisCourtDAL.Remove(tennisCourt);

            return new  JsonResult(tennisCourt);


        }


        #endregion
    }
}
