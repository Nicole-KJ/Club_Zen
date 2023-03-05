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
    public class EventoDALImpl : IEventoDAL
    {
        BD_Club_ZenContext context;


        public EventoDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public EventoDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Evento entity)
        {
            try
            {
                using (UnidadDeTrabajo<Evento> unidad = new UnidadDeTrabajo<Evento>(context))
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

        public void AddRange(IEnumerable<Evento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> Find(Expression<Func<Evento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Evento Get(int id)
        {
            Evento category;
            using (UnidadDeTrabajo<Evento> unidad = new UnidadDeTrabajo<Evento>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Evento> GetAll()
        {
            try
            {
                IEnumerable<Evento> categories;
                using (UnidadDeTrabajo<Evento> unidad = new UnidadDeTrabajo<Evento>(context))
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

        public bool Remove(Evento entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Evento> unidad = new UnidadDeTrabajo<Evento>(context))
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

        public void RemoveRange(IEnumerable<Evento> entities)
        {
            throw new NotImplementedException();
        }

        public Evento SingleOrDefault(Expression<Func<Evento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Evento entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Evento> unidad = new UnidadDeTrabajo<Evento>(context))
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
