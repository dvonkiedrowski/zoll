namespace Zoll
{
    using global::Zoll.Models.Base;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MIN_STEU")]
    public partial class Min_Steu : BaseEntity
    {
        public int MIN_STEUER_KZ { get; set; }

        public int OLGA_STEUER_KZ { get; set; }

        public int HAN_STEUER_KZ { get; set; }

        [StringLength(30)]
        public string BEZEICHNUNG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BETRAG_TO { get; set; }

        [Column(TypeName = "date")]
        public DateTime GUELTIG_AB { get; set; }

        [Column(TypeName = "date")]
        public DateTime GUELTIG_BIS { get; set; }
    }
}
