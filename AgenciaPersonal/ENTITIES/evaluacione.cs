namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.evaluaciones")]
    public partial class evaluacione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public evaluacione()
        {
            entrevistas_evaluaciones = new HashSet<entrevistas_evaluaciones>();
        }

        [Key]
        public int cod_evaluacion { get; set; }

        [Required]
        [StringLength(50)]
        public string desc_evaluacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrevistas_evaluaciones> entrevistas_evaluaciones { get; set; }
    }
}
