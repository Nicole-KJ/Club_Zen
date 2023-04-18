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
    public class MesaController : ControllerBase
    {

        private IMesaDAL mesaDAL;
        
        
        #region Constructor
        public MesaController()
        {
            mesaDAL = new MesaDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<MesaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.Mesa> mesas = mesaDAL.GetAll();


            return new JsonResult(mesas);
        }

        // GET api/<MesaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.Mesa mesa;
            mesa = mesaDAL.Get(id);


            return new JsonResult(mesa);

        }
        #endregion


        #region Agregar
        // POST api/<MesaController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.Mesa mesa)
        {
            mesaDAL.Add(mesa);
            return new JsonResult(mesa);

        }

        #endregion


        #region Modificar
        // PUT api/<MesaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.Mesa mesa)
        {

            mesaDAL.Update(mesa);
            return new JsonResult(mesa);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<MesaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.Mesa mesa = new Entities.Mesa { IdMesa = id };
            mesaDAL.Remove(mesa);

            return new  JsonResult(mesa);


        }


        #endregion
    }
}
