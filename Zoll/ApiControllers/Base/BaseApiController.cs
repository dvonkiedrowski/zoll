using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Zoll.Dtos.Base;
using Zoll.Models.Base;

namespace Zoll.ApiControllers.Base
{
    public class BaseApiController<TEntity, TDto> : ApiController
        where TEntity : BaseEntity
        where TDto : BaseDto
    {
        protected ZollContext context { get; set; }

        public BaseApiController()
        {
            context = new ZollContext();
        }

        // GET api/<controller>
        public virtual IEnumerable<TDto> Get()
        {
            var dbResult = context.Set<TEntity>().ToList();
            return Mapper.Map<List<TEntity>, IEnumerable<TDto>>(dbResult);
        }
    }
}