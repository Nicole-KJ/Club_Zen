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
    public class EventoController : ControllerBase
    {

        private IEventoDAL eventoDAL;
        
        
        #region Constructor
        public EventoController()
        {
            eventoDAL = new EventoDALImpl(new BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<EventoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Evento> eventos = eventoDAL.GetAll();


            return new JsonResult(eventos);
        }

        // GET api/<EventoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
           Evento evento;
            evento = eventoDAL.Get(id);


            return new JsonResult(evento);

        }
        #endregion


        #region Agregar
        // POST api/<EventoController>
        [HttpPost]
        public JsonResult Post([FromBody] Evento evento)
        {
            eventoDAL.Add(evento);
            return new JsonResult(evento);

        }

        #endregion


        #region Modificar
        // PUT api/<EventoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Evento evento)
        {

            eventoDAL.Update(evento);
            return new JsonResult(evento);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<EventoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Evento evento = new Evento { IdEvento = id };
            eventoDAL.Remove(evento);

            return new  JsonResult(evento);


        }


        #endregion
    }
}
