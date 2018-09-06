namespace GenbetaDevWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Persona
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido2 { get; set; }

        public DateTime Nacimiento { get; set; }

        public int ID { get; set; }
    }
}
