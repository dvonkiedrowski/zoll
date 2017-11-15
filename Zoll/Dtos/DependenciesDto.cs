using System;
using System.Collections.Generic;
using Zoll.Dtos.Base;

namespace Zoll.Dtos
{
    public class DependenciesDto
    {
        public IEnumerable<BaseDtoWithName> Min_Steus { get; set; }

        public IEnumerable<BaseDtoWithName> Filialen { get; set; }
    }
}