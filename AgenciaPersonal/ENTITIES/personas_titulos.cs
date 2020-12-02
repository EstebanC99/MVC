namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.personas_titulos")]
    public partial class personas_titulos
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string dni { get; set; }

        [Key]
        [Column(Order = 1)]
        public int cod_titulo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_graduacion { get; set; }

        public virtual persona persona { get; set; }

        public virtual titulo titulo { get; set; }
    }
}
