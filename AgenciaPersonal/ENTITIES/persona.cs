namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.personas")]
    public partial class persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persona()
        {
            antecedentes = new HashSet<antecedente>();
            contratos = new HashSet<contrato>();
            entrevistas = new HashSet<entrevista>();
            personas_titulos = new HashSet<personas_titulos>();
        }

        [Key]
        [StringLength(20)]
        public string dni { get; set; }

        [Required]
        [StringLength(30)]
        public string apellido { get; set; }

        [Required]
        [StringLength(30)]
        public string nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_nacimiento { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_registro_agencia { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<antecedente> antecedentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrato> contratos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrevista> entrevistas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personas_titulos> personas_titulos { get; set; }
    }
}
