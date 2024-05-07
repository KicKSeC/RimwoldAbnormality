﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Abnormality
{
    [DefOf]
    public static class PawnKindAbnormalityDefOf
    {
        [MayRequireAnomaly]
        public static PawnKindDef NothingThere;

        [MayRequireAnomaly]
        public static PawnKindDef OneSin;

        static PawnKindAbnormalityDefOf()
        { 
            DefOfHelper.EnsureInitializedInCtor(typeof(PawnKindDefOf));
        }
    }
}
