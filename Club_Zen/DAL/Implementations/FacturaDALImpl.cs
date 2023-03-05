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
    public class FacturaDALImpl : IFacturaDAL
    {
        BD_Club_ZenContext context;


        public FacturaDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public FacturaDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Factura entity)
        {
            try
            {
                using (UnidadDeTrabajo<Factura> unidad = new UnidadDeTrabajo<Factura>(context))
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

        public void AddRange(IEnumerable<Factura> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Factura> Find(Expression<Func<Factura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Factura Get(int id)
        {
            Factura category;
            using (UnidadDeTrabajo<Factura> unidad = new UnidadDeTrabajo<Factura>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Factura> GetAll()
        {
            try
            {
                IEnumerable<Factura> categories;
                using (UnidadDeTrabajo<Factura> unidad = new UnidadDeTrabajo<Factura>(context))
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

        public bool Remove(Factura entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Factura> unidad = new UnidadDeTrabajo<Factura>(context))
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

        public void RemoveRange(IEnumerable<Factura> entities)
        {
            throw new NotImplementedException();
        }

        public Factura SingleOrDefault(Expression<Func<Factura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Factura entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Factura> unidad = new UnidadDeTrabajo<Factura>(context))
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
