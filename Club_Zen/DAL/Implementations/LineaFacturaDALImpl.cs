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
    public class LineaFacturaDALImpl : ILineaFacturaDAL
    {
        BD_Club_ZenContext context;


        public LineaFacturaDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public LineaFacturaDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(LineaFactura entity)
        {
            try
            {
                using (UnidadDeTrabajo<LineaFactura> unidad = new UnidadDeTrabajo<LineaFactura>(context))
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

        public void AddRange(IEnumerable<LineaFactura> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LineaFactura> Find(Expression<Func<LineaFactura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LineaFactura Get(int id)
        {
            LineaFactura category;
            using (UnidadDeTrabajo<LineaFactura> unidad = new UnidadDeTrabajo<LineaFactura>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<LineaFactura> GetAll()
        {
            try
            {
                IEnumerable<LineaFactura> categories;
                using (UnidadDeTrabajo<LineaFactura> unidad = new UnidadDeTrabajo<LineaFactura>(context))
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

        public bool Remove(LineaFactura entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<LineaFactura> unidad = new UnidadDeTrabajo<LineaFactura>(context))
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

        public void RemoveRange(IEnumerable<LineaFactura> entities)
        {
            throw new NotImplementedException();
        }

        public LineaFactura SingleOrDefault(Expression<Func<LineaFactura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(LineaFactura entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<LineaFactura> unidad = new UnidadDeTrabajo<LineaFactura>(context))
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
