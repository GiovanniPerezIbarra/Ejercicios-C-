﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Data.Models
{
    public partial class Instructore
    {
        public Instructore()
        {
            CursosInstructores = new HashSet<CursosInstructore>();
        }

        public short IdInstructores { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public decimal CuotaHora { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CursosInstructore> CursosInstructores { get; set; }
    }
}
