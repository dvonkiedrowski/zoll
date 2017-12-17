using AutoMapper;
using System;
using System.Web.Http;
using Zoll.ApiControllers.Base;
using Zoll.Dtos;

namespace Zoll.ApiControllers
{
    public class ZollController : BaseApiController<Zoll, ZollDto>
    {
        public override ZollDto Post(ZollDto entity)
        {
            // at first there is only one tenant
            entity.MANDANT = 1;
            return base.Post(entity);
        }

        public override ZollDto Put([FromUri] int id, ZollDto entity)
        {
            var dbZoll = context.ZOLL.Find(id);

            if (dbZoll == null)
            {
                throw new ArgumentNullException("Datensatz nicht gefunden");
            }

            var newZoll = this.CopyZoll(dbZoll);

            context.ZOLL.Add(newZoll);
            context.SaveChanges();
            var mapped = Mapper.Map<Zoll, ZollDto>(newZoll);
            return mapped;
        }

        private Zoll CopyZoll(Zoll dbZoll)
        {
            return new Zoll
            {
                AEN_BEN = dbZoll.AEN_BEN,
                AEN_DAT = dbZoll.AEN_DAT,
                ANG_BEN = dbZoll.ANG_BEN,
                CUBEWARE_KZ = dbZoll.CUBEWARE_KZ,
                KU_FL_LFD_NR = dbZoll.KU_FL_LFD_NR,
                KU_NR = dbZoll.KU_NR,
                KU_TA_LFD_NR = dbZoll.KU_TA_LFD_NR,
                LAGER_KZ = dbZoll.LAGER_KZ,
                LIEF_DAT = dbZoll.LIEF_DAT,
                LIEF_FIL = dbZoll.LIEF_FIL,
                LIEF_NR = dbZoll.LIEF_NR,
                MANDANT = dbZoll.MANDANT,
                MIN_STEUER_KZ = dbZoll.MIN_STEUER_KZ,
                MNG_KG_AUSG = -dbZoll.MNG_KG_AUSG,
                MNG_KG_EING = -dbZoll.MNG_KG_EING,
                RECH_DAT = dbZoll.RECH_DAT,
                RECH_NR = dbZoll.RECH_NR,
                ZOLL_KZ = dbZoll.ZOLL_KZ,
                ZOLL_LIEF_KZ = dbZoll.ZOLL_LIEF_KZ
            };
        }
    }
}