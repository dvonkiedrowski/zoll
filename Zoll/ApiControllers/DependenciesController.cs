using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Zoll.Dtos;
using Zoll.Dtos.Base;

namespace Zoll.ApiControllers
{
    public class DependenciesController : ApiController
    {
        public DependenciesDto Get()
        {
            DependenciesDto result = new DependenciesDto();
            using (var context = new ZollContext())
            {
                result.Min_Steus = Mapper.Map<IEnumerable<Min_Steu>, IEnumerable<MinSteuDto>>(context.MIN_STEU as IEnumerable<Min_Steu>);
                result.Filialen = Mapper.Map<IEnumerable<Filiale>, IEnumerable<BaseDtoWithName>>(context.FILIALE as IEnumerable<Filiale>);
            }
            return result;
        }
    }
}