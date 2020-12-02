namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.solicitudes_empresas")]
    public partial class solicitudes_empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public solicitudes_empresas()
        {
            contratos = new HashSet<contrato>();
            entrevistas = new HashSet<entrevista>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string cuit { get; set; }

        [Key]
        [Column(Order = 1)]
        public int cod_cargo { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime fecha_solicitud { get; set; }

        public int? anios_experiencia { get; set; }

        public int? edad_minima { get; set; }

        public int? edad_maxima { get; set; }

        [StringLength(9)]
        public string sexo { get; set; }

        public virtual cargo cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrato> contratos { get; set; }

        public virtual empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrevista> entrevistas { get; set; }
    }
}
