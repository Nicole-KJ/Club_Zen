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
    public class RanchitoDALImpl : IRanchitoDAL
    {
        BD_Club_ZenContext context;


        public RanchitoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public RanchitoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Ranchito entity)
        {
            try
            {
                using (UnidadDeTrabajo<Ranchito> unidad = new UnidadDeTrabajo<Ranchito>(context))
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

        public void AddRange(IEnumerable<Ranchito> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ranchito> Find(Expression<Func<Ranchito, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Ranchito Get(int id)
        {
            Ranchito category;
            using (UnidadDeTrabajo<Ranchito> unidad = new UnidadDeTrabajo<Ranchito>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Ranchito> GetAll()
        {
            try
            {
                IEnumerable<Ranchito> categories;
                using (UnidadDeTrabajo<Ranchito> unidad = new UnidadDeTrabajo<Ranchito>(context))
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

        public bool Remove(Ranchito entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Ranchito> unidad = new UnidadDeTrabajo<Ranchito>(context))
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

        public void RemoveRange(IEnumerable<Ranchito> entities)
        {
            throw new NotImplementedException();
        }

        public Ranchito SingleOrDefault(Expression<Func<Ranchito, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ranchito entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Ranchito> unidad = new UnidadDeTrabajo<Ranchito>(context))
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
