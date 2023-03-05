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
    public class TennisCourtDALImpl : ITennisCourtDAL
    {
        BD_Club_ZenContext context;


        public TennisCourtDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public TennisCourtDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(TennisCourt entity)
        {
            try
            {
                using (UnidadDeTrabajo<TennisCourt> unidad = new UnidadDeTrabajo<TennisCourt>(context))
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

        public void AddRange(IEnumerable<TennisCourt> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TennisCourt> Find(Expression<Func<TennisCourt, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TennisCourt Get(int id)
        {
            TennisCourt category;
            using (UnidadDeTrabajo<TennisCourt> unidad = new UnidadDeTrabajo<TennisCourt>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<TennisCourt> GetAll()
        {
            try
            {
                IEnumerable<TennisCourt> categories;
                using (UnidadDeTrabajo<TennisCourt> unidad = new UnidadDeTrabajo<TennisCourt>(context))
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

        public bool Remove(TennisCourt entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<TennisCourt> unidad = new UnidadDeTrabajo<TennisCourt>(context))
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

        public void RemoveRange(IEnumerable<TennisCourt> entities)
        {
            throw new NotImplementedException();
        }

        public TennisCourt SingleOrDefault(Expression<Func<TennisCourt, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(TennisCourt entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<TennisCourt> unidad = new UnidadDeTrabajo<TennisCourt>(context))
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
