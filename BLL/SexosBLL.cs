﻿using Proyecto_Final_AP1.DAL;
using Proyecto_Final_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_AP1.BLL
{
    public class SexosBLL
    {
        public static List<Sexos> GetList(Expression<Func<Sexos, bool>> criterio)
        {
            List<Sexos> lista = new List<Sexos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Sexos.Where(criterio).ToList();
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
