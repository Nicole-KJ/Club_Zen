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
    public class PermisoController : ControllerBase
    {

        private IPermisoDAL permisoDAL;
        
        
        #region Constructor
        public PermisoController()
        {
            permisoDAL = new PermisoDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<PermisoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.Permiso> permisos = permisoDAL.GetAll();


            return new JsonResult(permisos);
        }

        // GET api/<PermisoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.Permiso permiso;
            permiso = permisoDAL.Get(id);


            return new JsonResult(permiso);

        }
        #endregion


        #region Agregar
        // POST api/<PermisoController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.Permiso permiso)
        {
            permisoDAL.Add(permiso);
            return new JsonResult(permiso);

        }

        #endregion


        #region Modificar
        // PUT api/<PermisoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.Permiso permiso)
        {

            permisoDAL.Update(permiso);
            return new JsonResult(permiso);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<PermisoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.Permiso permiso = new Entities.Permiso { IdPermiso = id };
            permisoDAL.Remove(permiso);

            return new  JsonResult(permiso);


        }


        #endregion
    }
}
