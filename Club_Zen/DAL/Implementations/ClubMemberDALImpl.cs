using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ClubMemberDALImpl : IClubMemberDAL
    {
        BD_Club_ZenContext context;


        public ClubMemberDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public ClubMemberDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(ClubMember entity)
        {
            try
            {
                using (UnidadDeTrabajo<ClubMember> unidad = new UnidadDeTrabajo<ClubMember>(context))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void AddRange(IEnumerable<ClubMember> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClubMember> Find(Expression<Func<ClubMember, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ClubMember Get(int id)
        {
            ClubMember category;
            using (UnidadDeTrabajo<ClubMember> unidad = new UnidadDeTrabajo<ClubMember>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ClubMember> GetAll()
        {
            try
            {
                IEnumerable<ClubMember> categories;
                using (UnidadDeTrabajo<ClubMember> unidad = new UnidadDeTrabajo<ClubMember>(context))
                {
                    categories = unidad.genericDAL.GetAll();
                }
                return categories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(ClubMember entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ClubMember> unidad = new UnidadDeTrabajo<ClubMember>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        public void RemoveRange(IEnumerable<ClubMember> entities)
        {
            throw new NotImplementedException();
        }

        public ClubMember SingleOrDefault(Expression<Func<ClubMember, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClubMember entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ClubMember> unidad = new UnidadDeTrabajo<ClubMember>(context))
                {
                    unidad.genericDAL.Update(entity);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                return false;
            }

            return result;
        }
    }
}
