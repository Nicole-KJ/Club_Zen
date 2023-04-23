using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EstadoDALImpl : IEstadoDAL
    {
        BD_Club_ZenContext context;


        public EstadoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public EstadoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Estado entity)
        {
            try
            {
                using (UnidadDeTrabajo<Estado> unidad = new UnidadDeTrabajo<Estado>(context))
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

        public void AddRange(IEnumerable<Estado> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estado> Find(Expression<Func<Estado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Estado Get(int id)
        {
            Estado category;
            using (UnidadDeTrabajo<Estado> unidad = new UnidadDeTrabajo<Estado>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Estado> GetAll()
        {
            try
            {
                IEnumerable<Estado> categories;
                using (UnidadDeTrabajo<Estado> unidad = new UnidadDeTrabajo<Estado>(context))
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

        public bool Remove(Estado entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Estado> unidad = new UnidadDeTrabajo<Estado>(context))
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

        public void RemoveRange(IEnumerable<Estado> entities)
        {
            throw new NotImplementedException();
        }

        public Estado SingleOrDefault(Expression<Func<Estado, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Estado entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Estado> unidad = new UnidadDeTrabajo<Estado>(context))
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
