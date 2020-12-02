namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.entrevistas_evaluaciones")]
    public partial class entrevistas_evaluaciones
    {
        [Key]
        [Column(Order = 0)]
        public int nro_entrevista { get; set; }

        [Key]
        [Column(Order = 1)]
        public int cod_evaluacion { get; set; }

        public int resultado { get; set; }

        public virtual entrevista entrevista { get; set; }

        public virtual evaluacione evaluacione { get; set; }
    }
}
