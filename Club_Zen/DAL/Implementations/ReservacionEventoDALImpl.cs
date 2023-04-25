using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ReservacionEventoDALImpl : IReservacionEventoDAL
    {
        BD_Club_ZenContext context;


        public ReservacionEventoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public ReservacionEventoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        #region Generic
        public bool Add(ReservacionEvento entity)
        {
            try
            {
                using (UnidadDeTrabajo<ReservacionEvento> unidad = new UnidadDeTrabajo<ReservacionEvento>(context))
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

        public void AddRange(IEnumerable<ReservacionEvento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservacionEvento> Find(Expression<Func<ReservacionEvento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReservacionEvento Get(int id)
        {
            ReservacionEvento category;
            using (UnidadDeTrabajo<ReservacionEvento> unidad = new UnidadDeTrabajo<ReservacionEvento>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ReservacionEvento> GetAll()
        {
            try
            {
                IEnumerable<ReservacionEvento> categories;
                using (UnidadDeTrabajo<ReservacionEvento> unidad = new UnidadDeTrabajo<ReservacionEvento>(context))
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

        public bool Remove(ReservacionEvento entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ReservacionEvento> unidad = new UnidadDeTrabajo<ReservacionEvento>(context))
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

        public void RemoveRange(IEnumerable<ReservacionEvento> entities)
        {
            throw new NotImplementedException();
        }

        public ReservacionEvento SingleOrDefault(Expression<Func<ReservacionEvento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ReservacionEvento entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ReservacionEvento> unidad = new UnidadDeTrabajo<ReservacionEvento>(context))
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
        #endregion

        #region StoredProcedures

        public IEnumerable<ReservacionEvento> GetMisReservacionesEvento(int idUsuario)
        {
            try
            {
                List<ReservacionEvento> reservacionesEvento = new List<ReservacionEvento>();

                List<sp_GetMisReservacionesEvento_Result> resultado;
                string sql = "[dbo].[sp_GetMisReservacionesEvento] @idUsuario";

                resultado = context.sp_GetMisReservacionesEvento_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesEvento.Add(new ReservacionEvento
                    {
                        IdReservacionEvento = item.IdReservacionEvento,
                        IdUsuario = item.IdUsuario,
                        IdEvento = item.IdEvento,
                        Personas = item.Personas
                    });
                }

                return reservacionesEvento;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
