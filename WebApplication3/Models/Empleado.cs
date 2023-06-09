﻿using System.ComponentModel.DataAnnotations;

namespace CuentasPorCobrar.Models
{
    public class Empleado
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int tipo_identificacionId { get; set; }
        [Required]
        //public String Direccion { get; set; }
        //[Required]
        public int estado_civilId { get; set; }
        [Required]
        public int generoId { get; set; }
        [Required]
        public int cargoId { get; set; }
        [Required]
        public String num_identificacion { get; set; }
        [Required]

        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public String fecha_nacimiento { get; set; }
        [Required]
        // [MaxLength(8, ErrorMessage = "Este campo solo acepta 8 caracteres")]
        public String telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int estado_RegistroEmpleado { get; set; }
    }
}
