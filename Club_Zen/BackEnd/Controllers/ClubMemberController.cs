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
    public class ClubMemberController : ControllerBase
    {

        private IClubMemberDAL clubMemberDAL;
        
        
        #region Constructor
        public ClubMemberController()
        {
            clubMemberDAL = new ClubMemberDALImpl(new Entities.BD_Club_ZenContext());

        }
        #endregion

        #region Consultar
        // GET: api/<CategoryController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Entities.ClubMember> clubmembers = clubMemberDAL.GetAll();


            return new JsonResult(clubmembers);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Entities.ClubMember clubmember;
            clubmember = clubMemberDAL.Get(id);


            return new JsonResult(clubmember);

        }
        #endregion


        #region Agregar
        // POST api/<CategoryController>
        [HttpPost]
        public JsonResult Post([FromBody] Entities.ClubMember clubmember)
        {
            clubMemberDAL.Add(clubmember);
            return new JsonResult(clubmember);

        }

        #endregion


        #region Modificar
        // PUT api/<CategoryController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Entities.ClubMember clubmember)
        {

            clubMemberDAL.Update(clubmember);
            return new JsonResult(clubmember);    

        }
        #endregion


        #region Eliminar
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Entities.ClubMember clubmember = new Entities.ClubMember { IdClubMember = id };
            clubMemberDAL.Remove(clubmember);

            return new  JsonResult(clubmember);


        }


        #endregion
    }
}
