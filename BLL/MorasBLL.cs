﻿using Microsoft.EntityFrameworkCore;
using Proyecto_Final_AP1.DAL;
using Proyecto_Final_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_AP1.BLL
{
    public class MorasBLL
    {
        public static bool Guardar(Moras mora)
        {
            if (!Existe(mora.MoraId))
            {
                return Insertar(mora);
            }
            else
            {
                return Modificar(mora);
            }
        }

        public static bool Insertar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                var Prestamo = contexto.Prestamos.Find(mora.PrestamoId);
                Prestamo.Mora += mora.Monto;
                contexto.Entry(Prestamo).State = EntityState.Modified;
                mora.Balance = Prestamo.Balance;

                contexto.Moras.Add(mora);
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

        public static bool Modificar(Moras mora)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var MoraAnterior = Buscar(mora.MoraId);
                var Prestamo = db.Prestamos.Find(mora.PrestamoId);

                if (MoraAnterior.PrestamoId != mora.PrestamoId)
                {
                    var PrestamoAnterior = db.Prestamos.Find(MoraAnterior.PrestamoId);
                    PrestamoAnterior.Mora -= MoraAnterior.Monto;
                    db.Entry(PrestamoAnterior).State = EntityState.Modified;
                }
                else
                {
                    Prestamo.Mora -= MoraAnterior.Monto;
                }

                Prestamo.Mora += mora.Monto;
                db.Entry(Prestamo).State = EntityState.Modified;

                mora.Balance = Prestamo.Balance;
                db.Entry(mora).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Moras mora = db.Moras.Find(id);
                if (Existe(id))
                {
                    var Prestamo = db.Prestamos.Find(mora.PrestamoId);
                    Prestamo.Mora -= mora.Monto;
                    db.Entry(Prestamo).State = EntityState.Modified;
                    mora.Balance = 0;

                    db.Moras.Remove(mora);
                    paso = db.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = db.Moras.Any(e => e.MoraId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static Moras Buscar(int id)
        {
            Contexto db = new Contexto();
            Moras negocio;
            try
            {
                negocio = db.Moras.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return negocio;
        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> criterio)
        {
            List<Moras> lista = new List<Moras>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Moras.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
