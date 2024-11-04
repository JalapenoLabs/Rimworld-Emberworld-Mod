using Verse;
using RimWorld;

namespace EmberWorld {
  public class GenStep_EmberWorld : GenStep {
    public override int SeedPart => 1182952823; // Unique identifier

    public override void Generate(Map map, GenStepParams parms) {
      // Check if the map's biome is your custom biome
      if (map.Biome.defName != "VolcanicRuins") {
        return;
      }

      // CONFIRMED, this part loads on the map

      // Define the number of additional geysers you want
      // int additionalGeysers = 10; // Adjust this number as needed

      // for (int i = 0; i < additionalGeysers; i++) {
      //   IntVec3 loc;
      //   // Find a suitable location for the geyser
      //   if (CellFinderLoose.TryFindRandomNotEdgeCellWith(10, c =>
      //       c.Standable(map) && !c.Roofed(map) && !c.Fogged(map) && c.GetEdifice(map) == null, map, out loc)) {
      //     // Place the steam geyser
      //     GenSpawn.Spawn(ThingDefOf.SteamGeyser, loc, map, WipeMode.Vanish);
      //   }
      // }
    }
  }
}
