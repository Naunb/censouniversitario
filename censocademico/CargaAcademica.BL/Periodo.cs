﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
   public class Periodo
    {
        
        public int Id  { get; set; }
        [Required(ErrorMessage = "ingrese el periodo")]
        public int numero { get; set; }
        public int año { get; set; }
        
    //    public Boolean activo { get; set; }
    }
}
