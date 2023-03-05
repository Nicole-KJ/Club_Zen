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
    public class PermisoDALImpl : IPermisoDAL
    {
        BD_Club_ZenContext context;


        public PermisoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public PermisoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Permiso entity)
        {
            try
            {
                using (UnidadDeTrabajo<Permiso> unidad = new UnidadDeTrabajo<Permiso>(context))
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

        public void AddRange(IEnumerable<Permiso> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Permiso> Find(Expression<Func<Permiso, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Permiso Get(int id)
        {
            Permiso category;
            using (UnidadDeTrabajo<Permiso> unidad = new UnidadDeTrabajo<Permiso>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Permiso> GetAll()
        {
            try
            {
                IEnumerable<Permiso> categories;
                using (UnidadDeTrabajo<Permiso> unidad = new UnidadDeTrabajo<Permiso>(context))
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

        public bool Remove(Permiso entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Permiso> unidad = new UnidadDeTrabajo<Permiso>(context))
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

        public void RemoveRange(IEnumerable<Permiso> entities)
        {
            throw new NotImplementedException();
        }

        public Permiso SingleOrDefault(Expression<Func<Permiso, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Permiso entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Permiso> unidad = new UnidadDeTrabajo<Permiso>(context))
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
