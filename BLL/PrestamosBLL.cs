﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_AP1.Entidades;
using Proyecto_Final_AP1.DAL;

namespace Proyecto_Final_AP1.BLL
{
    public class PrestamosBLL
    {
        static Prestamos prestamos = new Prestamos();
        public static bool Guardar(Prestamos prestamo)
        {
            prestamos.UsuarioId = MainWindow.user.UsuarioId;
            if (!Existe(prestamo.PrestamoId))
            {
                return Insertar(prestamo);
            }
            else
            {
                return Modificar(prestamo);
            }
        }

        public static bool Insertar(Prestamos prestamo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Prestamos.Add(prestamo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Prestamos prestamo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            prestamos.UsuarioId = MainWindow.user.UsuarioId;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM PrestamosDetalle Where PrestamoId ={prestamo.PrestamoId}");
                foreach (var item in prestamo.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                contexto.Entry(prestamo).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            prestamos.UsuarioId = MainWindow.user.UsuarioId;
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var Prestamos = contexto.Prestamos.Find(id);
                if (Prestamos != null)
                {
                    contexto.Entry(Prestamos).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Prestamos.Any(e => e.PrestamoId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static Prestamos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamos prestamo;
            try
            {
                prestamo = contexto.Prestamos.Include(e => e.Detalle).Where(p => p.PrestamoId == id).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return prestamo;
        }
        public static Prestamos BuscarSinTracking(int id)
        {
            Contexto contexto = new Contexto();
            Prestamos prestamo;
            try
            {
                prestamo = contexto.Prestamos.Include(x => x.Detalle).AsNoTracking().SingleOrDefault(p => p.PrestamoId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return prestamo;
        }

        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> criterio)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Prestamos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Prestamos> GetPrestamos()
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Prestamos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}