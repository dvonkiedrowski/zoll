using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var dbResult = context.Set<TEntity>() as IEnumerable<TEntity>;
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TDto>>(dbResult);
        }

        // GET api/<controller>/5
        public virtual TDto Get(int id)
        {
            var dbResult = context.Set<TEntity>().FirstOrDefault(t => t.RECNUM == id);
            return Mapper.Map<TEntity, TDto>(dbResult);
        }

        // POST api/<controller>
        public virtual TDto Post(TDto entity)
        {
            var mapped = Mapper.Map<TDto, TEntity>(entity);
            context.Set<TEntity>().Add(mapped);
            context.SaveChanges();
            return Mapper.Map<TEntity, TDto>(mapped);
        }

        // PUT api/<controller>/5
        public virtual TDto Put([FromUri] int id, TDto entity)
        {
            var mapped = Mapper.Map<TDto, TEntity>(entity);
            var dbEntity = context.Set<TEntity>().FirstOrDefault(t => t.RECNUM == id);
            context.Entry(dbEntity).CurrentValues.SetValues(mapped);
            context.SaveChanges();
            return Mapper.Map<TEntity, TDto>(dbEntity);
        }
    }
}