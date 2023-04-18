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
    public class EstadoController : ControllerBase
    {

        private IEstadoDAL estadoDAL;
        
        
        #region Constructor
        public EstadoController()
        {
            estadoDAL = new EstadoDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<EstadoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.Estado> estados = estadoDAL.GetAll();


            return new JsonResult(estados);
        }

        // GET api/<EstadoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.Estado estado;
            estado = estadoDAL.Get(id);


            return new JsonResult(estado);

        }
        #endregion


        #region Agregar
        // POST api/<EstadoController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.Estado estado)
        {
            estadoDAL.Add(estado);
            return new JsonResult(estado);

        }

        #endregion


        #region Modificar
        // PUT api/<EstadoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.Estado estado)
        {

            estadoDAL.Update(estado);
            return new JsonResult(estado);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<EstadoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.Estado estado = new Entities.Estado { IdEstado = id };
            estadoDAL.Remove(estado);

            return new  JsonResult(estado);


        }


        #endregion
    }
}
