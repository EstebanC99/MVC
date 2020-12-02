namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;




    [Table("agencia_personal.entrevistas")]
    public partial class entrevista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public entrevista()
        {
            entrevistas_evaluaciones = new HashSet<entrevistas_evaluaciones>();
        }

        [Key]
        public int nro_entrevista { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_entrevista { get; set; }

        public TimeSpan hora_entrevista { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_entrevistador { get; set; }

        [StringLength(20)]
        public string resultado_final { get; set; }

        [Required]
        [StringLength(20)]
        public string dni { get; set; }

        [Required]
        [StringLength(20)]
        public string cuit { get; set; }

        public int cod_cargo { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_solicitud { get; set; }

        public virtual solicitudes_empresas solicitudes_empresas { get; set; }

        public virtual persona persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrevistas_evaluaciones> entrevistas_evaluaciones { get; set; }
    }
}
