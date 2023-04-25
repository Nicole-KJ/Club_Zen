﻿using DAL.Interfaces;
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
    public class UsuarioDALImpl : IUsuarioDAL
    {
        BD_Club_ZenContext context;


        public UsuarioDALImpl()
        {
            context = new BD_Club_ZenContext();

        }

        public UsuarioDALImpl(BD_Club_ZenContext _Context)
        {
            context = _Context;

        }

        public bool Add(Usuario entity)
        {
            try
            {
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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

        public void AddRange(IEnumerable<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Find(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            Usuario category;
            using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
            {
               
                category= unidad.genericDAL.Get(id);
            }
            return category;

        }

        public IEnumerable<Usuario> GetAll()
        {
            try
            {  
                List<Usuario> usuarios = new List<Usuario>();

                List<sp_GetAllUsuarios_Result> resultado;

                string sql = "[dbo].[sp_GetALLUsuarios]";


                resultado = context.sp_GetAllUsuarios_Result
                        .FromSqlRaw(sql)
                        .ToList();  

                foreach (var item in resultado)
                {
                    usuarios.Add(
                        new Usuario
                        {                           
                            Cedula = item.Cedula,
                            Nombre = item.Nombre,
                            Apellido = item.Apellido,
                            FechaNacimiento = item.FechaNacimiento,
                            Correo = item.Correo
                        }
                        );
                }
                return usuarios;
            }
            catch (Exception)
            {

                throw;

            }

        }

        public bool Remove(Usuario entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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

        public void RemoveRange(IEnumerable<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public Usuario SingleOrDefault(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario entity)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Usuario> unidad = new UnidadDeTrabajo<Usuario>(context))
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
