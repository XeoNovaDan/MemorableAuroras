using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;

namespace LastingAurora
{
    public class GameCondition_AuroraLasting : GameCondition_Aurora
    {

        public override void GameConditionTick()
        {
            base.GameConditionTick();
            foreach (Map map in AffectedMaps)
            {
                for (int i = 0; i < map.mapPawns.AllPawnsSpawnedCount; i++)
                {
                    Pawn pawn = map.mapPawns.AllPawnsSpawned[i];
                    if (pawn.needs.mood != null && !pawn.PositionHeld.Roofed(map) && pawn.health.capacities.CapableOf(PawnCapacityDefOf.Sight))
                        pawn.needs.mood.thoughts.memories.TryGainMemory((Thought_Memory)ThoughtMaker.MakeThought(LA_ThoughtDefOf.ObservedAurora));
                }
            }
        }

    }
}
