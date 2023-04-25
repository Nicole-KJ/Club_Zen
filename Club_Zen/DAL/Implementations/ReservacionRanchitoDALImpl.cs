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
    public class ReservacionRanchitoDALImpl : IReservacionRanchitoDAL
    {
        BD_Club_ZenContext context;


        public ReservacionRanchitoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public ReservacionRanchitoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        #region Generic
        public bool Add(ReservacionRanchito entity)
        {
            try
            {
                using (UnidadDeTrabajo<ReservacionRanchito> unidad = new UnidadDeTrabajo<ReservacionRanchito>(context))
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

        public void AddRange(IEnumerable<ReservacionRanchito> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservacionRanchito> Find(Expression<Func<ReservacionRanchito, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ReservacionRanchito Get(int id)
        {
            ReservacionRanchito category;
            using (UnidadDeTrabajo<ReservacionRanchito> unidad = new UnidadDeTrabajo<ReservacionRanchito>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<ReservacionRanchito> GetAll()
        {
            try
            {
                IEnumerable<ReservacionRanchito> categories;
                using (UnidadDeTrabajo<ReservacionRanchito> unidad = new UnidadDeTrabajo<ReservacionRanchito>(context))
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

        public bool Remove(ReservacionRanchito entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<ReservacionRanchito> unidad = new UnidadDeTrabajo<ReservacionRanchito>(context))
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

        public void RemoveRange(IEnumerable<ReservacionRanchito> entities)
        {
            throw new NotImplementedException();
        }

        public ReservacionRanchito SingleOrDefault(Expression<Func<ReservacionRanchito, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ReservacionRanchito entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<ReservacionRanchito> unidad = new UnidadDeTrabajo<ReservacionRanchito>(context))
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

        public IEnumerable<ReservacionRanchito> GetMisReservacionesRanchito(int idUsuario)
        {
            try
            {
                List<ReservacionRanchito> reservacionesRanchito = new List<ReservacionRanchito>();

                List<sp_GetMisReservacionesRanchito_Result> resultado;
                string sql = "[dbo].[sp_GetMisReservacionesRanchito] @idUsuario";

                resultado = context.sp_GetMisReservacionesRanchito_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesRanchito.Add(new ReservacionRanchito
                    {
                        IdReservacionRanchito = item.IdReservacionRanchito,
                        IdRanchito = item.IdRanchito,
                        IdUsuario = item.IdUsuario,
                        FechaReserva = item.FechaReserva
                    });
                }

                return reservacionesRanchito;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ReservacionRanchito> GetRanchitosReservadosEnHora(DateOnly fecha)
        {
            try
            {
                List<ReservacionRanchito> reservacionesRanchito = new List<ReservacionRanchito>();

                List<sp_GetRanchitosReservadosEnHora_Result> resultado;
                string sql = "[dbo].[sp_GetRanchitosReservadosEnHora] @fecha";

                resultado = context.sp_GetRanchitosReservadosEnHora_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    reservacionesRanchito.Add(new ReservacionRanchito
                    {
                        IdReservacionRanchito = item.IdReservacionRanchito,
                        IdRanchito = item.IdRanchito,
                        IdUsuario = item.IdUsuario,
                        FechaReserva = item.FechaReserva
                    });
                }

                return reservacionesRanchito;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
