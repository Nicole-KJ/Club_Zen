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
    public class RanchitoController : ControllerBase
    {

        private IRanchitoDAL ranchitoDAL;
        
        
        #region Constructor
        public RanchitoController()
        {
            ranchitoDAL = new RanchitoDALImpl(new BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<RanchitoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Ranchito> ranchitos = ranchitoDAL.GetAll();


            return new JsonResult(ranchitos);
        }

        // GET api/<RanchitoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Ranchito ranchito;
            ranchito = ranchitoDAL.Get(id);


            return new JsonResult(ranchito);

        }
        #endregion


        #region Agregar
        // POST api/<RanchitoController>
        [HttpPost]
        public JsonResult Post([FromBody] Ranchito ranchito)
        {
            ranchitoDAL.Add(ranchito);
            return new JsonResult(ranchito);

        }

        #endregion


        #region Modificar
        // PUT api/<RanchitoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Ranchito ranchito)
        {

            ranchitoDAL.Update(ranchito);
            return new JsonResult(ranchito);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<RanchitoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Ranchito ranchito = new Ranchito { IdRanchito = id };
            ranchitoDAL.Remove(ranchito);

            return new  JsonResult(ranchito);


        }


        #endregion
    }
}
