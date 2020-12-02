namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.titulos")]
    public partial class titulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public titulo()
        {
            personas_titulos = new HashSet<personas_titulos>();
        }

        [Key]
        public int cod_titulo { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_titulo { get; set; }

        [StringLength(50)]
        public string tipo_titulo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personas_titulos> personas_titulos { get; set; }
    }
}
