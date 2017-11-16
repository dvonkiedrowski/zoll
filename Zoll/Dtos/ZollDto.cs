namespace Zoll
{
    using global::Zoll.Dtos.Base;
    using System;
    
    public partial class ZollDto : BaseDto
    {
        public int MANDANT { get; set; }

        public int LIEF_FIL { get; set; }
        
        public DateTime LIEF_DAT { get; set; }
        
        public decimal LIEF_NR { get; set; }
        
        public decimal KU_NR { get; set; }

        public short KU_TA_LFD_NR { get; set; }

        public short KU_FL_LFD_NR { get; set; }
        
        public DateTime RECH_DAT { get; set; }
        
        public decimal RECH_NR { get; set; }

        public int MIN_STEUER_KZ { get; set; }
        
        public string ZOLL_KZ { get; set; }
        
        public decimal MNG_KG_AUSG { get; set; }

        public short LAGER_KZ { get; set; }

        public short ZOLL_LIEF_KZ { get; set; }
        
        public string CUBEWARE_KZ { get; set; }
        
        public string ANG_BEN { get; set; }
        
        public DateTime AEN_DAT { get; set; }

        public string AEN_BEN { get; set; }

        public decimal MNG_KG_EING { get; set; }

        public Filiale LIEF_FIL_Ref { get; set; }

        public Min_Steu MIN_STEU_Ref { get; set; }
    }
}
