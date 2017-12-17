using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoll.Models.Base
{
    public class BaseTenantEntity : BaseEntity
    {
        public int MANDANT { get; set; }

      
    }
}