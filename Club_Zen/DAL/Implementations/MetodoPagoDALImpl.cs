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
    public class MetodoPagoDALImpl : IMetodoPagoDAL
    {
        BD_Club_ZenContext context;


        public MetodoPagoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public MetodoPagoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(MetodoPago entity)
        {
            try
            {
                using (UnidadDeTrabajo<MetodoPago> unidad = new UnidadDeTrabajo<MetodoPago>(context))
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

        public void AddRange(IEnumerable<MetodoPago> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MetodoPago> Find(Expression<Func<MetodoPago, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MetodoPago Get(int id)
        {
            MetodoPago category;
            using (UnidadDeTrabajo<MetodoPago> unidad = new UnidadDeTrabajo<MetodoPago>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<MetodoPago> GetAll()
        {
            try
            {
                IEnumerable<MetodoPago> categories;
                using (UnidadDeTrabajo<MetodoPago> unidad = new UnidadDeTrabajo<MetodoPago>(context))
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

        public bool Remove(MetodoPago entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<MetodoPago> unidad = new UnidadDeTrabajo<MetodoPago>(context))
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

        public void RemoveRange(IEnumerable<MetodoPago> entities)
        {
            throw new NotImplementedException();
        }

        public MetodoPago SingleOrDefault(Expression<Func<MetodoPago, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(MetodoPago entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<MetodoPago> unidad = new UnidadDeTrabajo<MetodoPago>(context))
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
