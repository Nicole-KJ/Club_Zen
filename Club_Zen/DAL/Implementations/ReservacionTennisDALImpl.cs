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

        public bool Add(ReservacionTenni entity)
        {
            try
            {
                using (UnidadDeTrabajo<ReservacionTenni> unidad = new UnidadDeTrabajo<ReservacionTenni>(context))
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

        public void AddRange(IEnumerable<ReservacionTenni> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservacionTenni> Find(Expression<Func<ReservacionTenni, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReservacionTenni Get(int id)
        {
            ReservacionTenni category;
            using (UnidadDeTrabajo<ReservacionTenni> unidad = new UnidadDeTrabajo<ReservacionTenni>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ReservacionTenni> GetAll()
        {
            try
            {
                IEnumerable<ReservacionTenni> categories;
                using (UnidadDeTrabajo<ReservacionTenni> unidad = new UnidadDeTrabajo<ReservacionTenni>(context))
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

        public bool Remove(ReservacionTenni entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ReservacionTenni> unidad = new UnidadDeTrabajo<ReservacionTenni>(context))
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

        public void RemoveRange(IEnumerable<ReservacionTenni> entities)
        {
            throw new NotImplementedException();
        }

        public ReservacionTenni SingleOrDefault(Expression<Func<ReservacionTenni, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ReservacionTenni entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ReservacionTenni> unidad = new UnidadDeTrabajo<ReservacionTenni>(context))
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






        #region StoredProcedures

        public IEnumerable<ReservacionTenni> GetMisReservacionesTennis(int idUsuario)
        {
            try
            {
                List<ReservacionTenni> reservacionesTennis = new List<ReservacionTenni>();

                List<sp_GetMisReservacionesTennis_Result> resultado;
                string sql = "[dbo].[sp_GetMisReservacionesTennis] @idUsuario";

                resultado = context.sp_GetMisReservacionesTennis_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesTennis.Add(new ReservacionTenni
                    {
                        IdReservacionTennis = item.IdReservacionTennis,
                        IdUsuario = item.IdUsuario,
                        IdTennisCourt = item.IdTennisCourt,
                        FechaInicio = item.FechaInicio,
                        FechaFin = item.FechaFin
                    });
                }

                return reservacionesTennis;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<ReservacionTenni> GetTennisReservadosEnHora(DateTime fecha)
        {
            try
            {
                List<ReservacionTenni> reservacionesTennis = new List<ReservacionTenni>();

                List<sp_GetTennisReservadosEnHora_Result> resultado;
                string sql = "[dbo].[sp_sp_GetTennisReservadosEnHora] @fecha";

                resultado = context.sp_GetTennisReservadosEnHora_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesTennis.Add(new ReservacionTenni
                    {
                        IdReservacionTennis = item.IdReservacionTennis,
                        IdUsuario = item.IdUsuario,
                        IdTennisCourt = item.IdTennisCourt,
                        FechaInicio = item.FechaInicio,
                        FechaFin = item.FechaFin
                    });
                }

                return reservacionesTennis;
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion
    }
}
