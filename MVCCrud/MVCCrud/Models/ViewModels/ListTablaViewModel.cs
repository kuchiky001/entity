﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrud.Models.ViewModels
{
    public class ListTablaViewModel
    {
        internal DateTime? fecha_nacimiento;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}