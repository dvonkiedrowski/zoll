namespace Zoll
{
    using global::Zoll.Models.Base;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FILIALE")]
    public partial class Filiale : BaseEntity
    {
        public short NR { get; set; }

        [StringLength(30)]
        public string BEZ { get; set; }

        [StringLength(13)]
        public string KURZ_BEZ { get; set; }

        [StringLength(6)]
        public string OLGA_NR { get; set; }

        [StringLength(6)]
        public string Handel_NR { get; set; }
    }
}
