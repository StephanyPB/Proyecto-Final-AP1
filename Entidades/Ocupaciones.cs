﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_AP1.Entidades
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }
        public string Descripcion { get; set; }
    }
}
