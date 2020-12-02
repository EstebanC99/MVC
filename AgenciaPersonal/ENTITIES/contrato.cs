namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;




    [Table("agencia_personal.contratos")]
    public partial class contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contrato()
        {
            comisiones = new HashSet<comisione>();
        }

        [Key]
        public int nro_contrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_incorporacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_finalizacion_contrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_caducidad { get; set; }

        public decimal sueldo { get; set; }

        public decimal porcentaje_comision { get; set; }

        [Required]
        [StringLength(20)]
        public string dni { get; set; }

        [Required]
        [StringLength(20)]
        public string cuit { get; set; }

        public int cod_cargo { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comisione> comisiones { get; set; }

        public virtual persona persona { get; set; }

        public virtual solicitudes_empresas solicitudes_empresas { get; set; }
    }
}
