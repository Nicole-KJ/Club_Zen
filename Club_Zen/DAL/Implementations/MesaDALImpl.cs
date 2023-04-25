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
    public class MesaDALImpl : IMesaDAL
    {
        BD_Club_ZenContext context;


        public MesaDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public MesaDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }
        #region Generic
        public bool Add(Mesa entity)
        {
            try
            {
                using (UnidadDeTrabajo<Mesa> unidad = new UnidadDeTrabajo<Mesa>(context))
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

        public void AddRange(IEnumerable<Mesa> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mesa> Find(Expression<Func<Mesa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Mesa Get(int id)
        {
            Mesa category;
            using (UnidadDeTrabajo<Mesa> unidad = new UnidadDeTrabajo<Mesa>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Mesa> GetAll()
        {
            try
            {
                IEnumerable<Mesa> categories;
                using (UnidadDeTrabajo<Mesa> unidad = new UnidadDeTrabajo<Mesa>(context))
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

        public bool Remove(Mesa entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Mesa> unidad = new UnidadDeTrabajo<Mesa>(context))
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

        public void RemoveRange(IEnumerable<Mesa> entities)
        {
            throw new NotImplementedException();
        }

        public Mesa SingleOrDefault(Expression<Func<Mesa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Mesa entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Mesa> unidad = new UnidadDeTrabajo<Mesa>(context))
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

        public IEnumerable<Mesa> GetMesasParaCantidad(int cantidad)
        {
            try
            {
                List<Mesa> mesas = new List<Mesa>();

                List<sp_GetMesasParaCantidad_Result> resultado;
                string sql = "[dbo].[sp_GetMesasParaCantidad] @cantidad";

                resultado = context.sp_GetMesasParaCantidad_Results.FromSqlRaw(sql).ToList();

                foreach (var item in resultado)
                {
                    mesas.Add(new Mesa
                    {
                        IdMesa = item.IdMesa,
                        Cantidad = item.Cantidad
                    });
                }

                return mesas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
