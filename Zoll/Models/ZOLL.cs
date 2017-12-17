namespace Zoll
{
    using global::Zoll.Models.Base;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ZOLLEIN")]
    public partial class Zoll : BaseTenantEntity
    {
        public int LIEF_FIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime LIEF_DAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIEF_NR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal KU_NR { get; set; }

        public short KU_TA_LFD_NR { get; set; }

        public short KU_FL_LFD_NR { get; set; }

        [Column(TypeName = "date")]
        public DateTime RECH_DAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RECH_NR { get; set; }

        public int MIN_STEUER_KZ { get; set; }

        [StringLength(2)]
        public string ZOLL_KZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MNG_KG_AUSG { get; set; }

        public short LAGER_KZ { get; set; }

        public short ZOLL_LIEF_KZ { get; set; }

        [StringLength(15)]
        public string CUBEWARE_KZ { get; set; }

        [StringLength(5)]
        public string ANG_BEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime AEN_DAT { get; set; }

        [StringLength(5)]
        public string AEN_BEN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MNG_KG_EING { get; set; }

        [ForeignKey("LIEF_FIL")]
        public virtual Filiale LIEF_FIL_Ref { get; set; }

        [ForeignKey("MIN_STEUER_KZ")]
        public virtual Min_Steu MIN_STEU_Ref { get; set; }
    }
}
