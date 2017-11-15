using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoll.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int RECNUM { get; set; }
    }
}