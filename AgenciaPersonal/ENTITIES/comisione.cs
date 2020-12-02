namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("agencia_personal.comisiones")]
    public partial class comisione
    {
        [Key]
        [Column(Order = 0)]
        public int nro_contrato { get; set; }

        [Key]
        [Column(Order = 1)]
        public int anio_contrato { get; set; }

        [Key]
        [Column(Order = 2)]
        public int mes_contrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_pago { get; set; }

        public decimal? importe_comision { get; set; }

        public virtual contrato contrato { get; set; }
    }
}
