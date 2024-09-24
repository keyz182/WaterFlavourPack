﻿using RimWorld;
using Verse;

namespace Thirst_Flavour_Pack.VictoryQuest;

public class QuestPart_Filter_PowerRegulator(int count = 3) : QuestPart_Filter
{
    public int Count = count;

    protected override bool Pass(SignalArgs args)
    {
        return WaterVictoryWorldComponent.Instance.PowerRegulatorsBuilt >= Count;
    }

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref Count, "Count");
    }
}
