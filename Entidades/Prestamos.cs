﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_AP1.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int Cuotas { get; set; }
        public decimal Monto { get; set; }
        public decimal Interes { get; set; }
        public decimal Balance { get; set; }
        public decimal Mora { get; set; }
        [ForeignKey("PrestamoId")]
        public List<PrestamosDetalle> Detalle { get; set; }
        [ForeignKey("ClientesId")] 
        public int ClientesId { get; set; }
        public virtual Clientes Clientes { get; set; }
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuarios { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Monto =0;
            Mora = 0;
            Cuotas = 0;
            Interes = 0;
            Balance = 0;
            Detalle = new List<PrestamosDetalle>();
        }
        public void RecalcularBalance()
        {
            Balance = this.Detalle.Sum(x => x.BalanceCapital + x.BalanceInteres);
        }
    }
}
