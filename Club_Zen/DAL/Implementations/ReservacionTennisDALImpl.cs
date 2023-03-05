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
    public class ReservacionTennisDALImpl : IReservacionTennisDAL
    {
        BD_Club_ZenContext context;


        public ReservacionTennisDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public ReservacionTennisDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(ReservacionTennis entity)
        {
            try
            {
                using (UnidadDeTrabajo<ReservacionTennis> unidad = new UnidadDeTrabajo<ReservacionTennis>(context))
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

        public void AddRange(IEnumerable<ReservacionTennis> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservacionTennis> Find(Expression<Func<ReservacionTennis, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReservacionTennis Get(int id)
        {
            ReservacionTennis category;
            using (UnidadDeTrabajo<ReservacionTennis> unidad = new UnidadDeTrabajo<ReservacionTennis>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ReservacionTennis> GetAll()
        {
            try
            {
                IEnumerable<ReservacionTennis> categories;
                using (UnidadDeTrabajo<ReservacionTennis> unidad = new UnidadDeTrabajo<ReservacionTennis>(context))
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

        public bool Remove(ReservacionTennis entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ReservacionTennis> unidad = new UnidadDeTrabajo<ReservacionTennis>(context))
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

        public void RemoveRange(IEnumerable<ReservacionTennis> entities)
        {
            throw new NotImplementedException();
        }

        public ReservacionTennis SingleOrDefault(Expression<Func<ReservacionTennis, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ReservacionTennis entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ReservacionTennis> unidad = new UnidadDeTrabajo<ReservacionTennis>(context))
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
