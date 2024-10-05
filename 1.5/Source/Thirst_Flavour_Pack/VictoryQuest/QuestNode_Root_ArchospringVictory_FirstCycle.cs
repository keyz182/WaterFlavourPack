﻿using RimWorld;
using RimWorld.QuestGen;
using Verse;

namespace Thirst_Flavour_Pack.VictoryQuest;

public class QuestNode_Root_ArchospringVictory_FirstCycle: QuestNode_Root_ArchospringVictory_Cycle
{
    protected override int WaterCycle => 1;
    protected override string QuestSignal => "PowerRegulatorBuilt";
    protected override QuestPart_Filter QuestPartFilter => new QuestPart_Filter_ArchoSpringBuilding(Thirst_Flavour_PackDefOf.MSS_PowerRegulator, 3);

    protected override QuestPart_RequirementToAcceptBuildingHasComponents Requirement =>
        new QuestPart_RequirementToAcceptBuildingHasComponents(Thirst_Flavour_PackDefOf.MSS_PowerRegulator);

    protected override bool SetSuccess => true;
}
