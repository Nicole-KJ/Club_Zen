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
    public class UsuarioController : ControllerBase
    {

        private IUsuarioDAL usuarioDAL;
        
        
        #region Constructor
        public UsuarioController()
        {
            usuarioDAL = new UsuarioDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<TennisCourtController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.Usuario> usuarios = usuarioDAL.GetAll();


            return new JsonResult(usuarios);
        }

        // GET api/<TennisCourtController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.Usuario usuario;
            usuario = usuarioDAL.Get(id);


            return new JsonResult(usuario);

        }
        #endregion


        #region Agregar
        // POST api/<TennisCourtController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.Usuario usuario)
        {
            usuarioDAL.Add(usuario);
            return new JsonResult(usuario);

        }

        #endregion


        #region Modificar
        // PUT api/<TennisCourtController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.Usuario usuario)
        {

            usuarioDAL.Update(usuario);
            return new JsonResult(usuario);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<TennisCourtController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.Usuario usuario = new Entities.Usuario { IdUsuario = id };
            usuarioDAL.Remove(usuario);

            return new  JsonResult(usuario);


        }


        #endregion
    }
}
