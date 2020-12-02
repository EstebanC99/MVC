namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.empresas")]
    public partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empresa()
        {
            antecedentes = new HashSet<antecedente>();
            solicitudes_empresas = new HashSet<solicitudes_empresas>();
        }

        [Key]
        [StringLength(20)]
        public string cuit { get; set; }

        [Required]
        [StringLength(50)]
        public string razon_social { get; set; }

        [Required]
        [StringLength(50)]
        public string direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<antecedente> antecedentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudes_empresas> solicitudes_empresas { get; set; }
    }
}
