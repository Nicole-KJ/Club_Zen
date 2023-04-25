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
    public class ReservacionMesaDALImpl : IReservacionMesaDAL
    {
        BD_Club_ZenContext context;

        public ReservacionMesaDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public ReservacionMesaDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        #region Generic
        public bool Add(ReservacionMesa entity)
        {
            try
            {
                using (UnidadDeTrabajo<ReservacionMesa> unidad = new UnidadDeTrabajo<ReservacionMesa>(context))
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

        public void AddRange(IEnumerable<ReservacionMesa> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservacionMesa> Find(Expression<Func<ReservacionMesa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReservacionMesa Get(int id)
        {
            ReservacionMesa category;
            using (UnidadDeTrabajo<ReservacionMesa> unidad = new UnidadDeTrabajo<ReservacionMesa>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ReservacionMesa> GetAll()
        {
            try
            {
                IEnumerable<ReservacionMesa> categories;
                using (UnidadDeTrabajo<ReservacionMesa> unidad = new UnidadDeTrabajo<ReservacionMesa>(context))
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

        public bool Remove(ReservacionMesa entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ReservacionMesa> unidad = new UnidadDeTrabajo<ReservacionMesa>(context))
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

        public void RemoveRange(IEnumerable<ReservacionMesa> entities)
        {
            throw new NotImplementedException();
        }

        public ReservacionMesa SingleOrDefault(Expression<Func<ReservacionMesa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ReservacionMesa entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ReservacionMesa> unidad = new UnidadDeTrabajo<ReservacionMesa>(context))
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

        public IEnumerable<ReservacionMesa> GetMisReservacionesMesa()
        {
            try
            {
                List<ReservacionMesa> reservacionesMesa = new List<ReservacionMesa>();

                List<sp_GetMisReservacionesMesa_Result> resultado;
                string sql = "[dbo].[sp_GetMisReservacionesMesa] @idUsuario";

                resultado = context.sp_GetMisReservacionesMesa_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesMesa.Add(new ReservacionMesa
                    {
                        IdReservacionMesa = item.IdReservacionMesa,
                        IdMesa = item.IdMesa,
                        IdUsuario = item.IdUsuario,
                        FechaInicio = item.FechaInicio, 
                        FechaFin = item.FechaFin,
                        Personas = item.Personas
                    });
                }

                return reservacionesMesa;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }
}
