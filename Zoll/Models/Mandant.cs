using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Zoll.Models.Base;

namespace Zoll.Models
{
    [Table("MANDANT")]
    public class Mandant : BaseEntity
    {
        [StringLength(30)]
        public string BEZ { get; set; }
    }
}