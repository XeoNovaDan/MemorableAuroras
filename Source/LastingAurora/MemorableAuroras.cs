using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;
using HarmonyLib;

namespace MemorableAuroras
{

    public class MemorableAuroras : Mod
    {

        public MemorableAuroras(ModContentPack content) : base(content)
        {
            HarmonyInstance = new Harmony("XeoNovaDan.MemorableAuroras");
        }

        public static Harmony HarmonyInstance;

    }

}
