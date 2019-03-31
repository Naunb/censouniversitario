using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class Asignatura
    {
        public int Id { get; set; }
        [Display(Name = "Seccion")]
        [Required(ErrorMessage = "Ingrese el asignatura")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "ingrese un maximo de 20 caracteres")]
        public string Seccion { get; set; }
        [Required(ErrorMessage = "Ingrese el Seccion")]
        [Range(0, 4, ErrorMessage = "ingrese un año entres 0 y 4")]

        public string NumeroEdificio { get; set; }
        public string NombreAsignatura { get; set; }
        public int asignaturaId { get; set; }
        public string NombreCatedratico { get; set; }
        public Asignatura asignatura { get; set; }
        
        [Display (Name = " Imagen")]
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }

    }
}
