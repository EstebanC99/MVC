namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("agencia_personal.antecedentes")]
    public partial class antecedente
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string dni { get; set; }

        [Key]
        [Column(Order = 1)]
        public int cod_cargo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string cuit { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime fecha_desde { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_hasta { get; set; }

        [StringLength(50)]
        public string persona_contacto { get; set; }

        public virtual cargo cargo { get; set; }

        public virtual empresa empresa { get; set; }

        public virtual persona persona { get; set; }
    }
}
