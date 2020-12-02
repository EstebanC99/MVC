namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.cargos")]
    public partial class cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cargo()
        {
            antecedentes = new HashSet<antecedente>();
            solicitudes_empresas = new HashSet<solicitudes_empresas>();
        }

        [Key]
        public int cod_cargo { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<antecedente> antecedentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudes_empresas> solicitudes_empresas { get; set; }
    }
}
