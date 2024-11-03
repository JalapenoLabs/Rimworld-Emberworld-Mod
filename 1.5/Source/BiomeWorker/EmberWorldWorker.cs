using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;


namespace EmberWorld {
  public class BiomeWorker_VolcanicRuins : BiomeWorker {
    // The hotter == the more likely to spawn
    // The colder == the less likely to spawn

    // Rain is hardly a factor, but we'll give a slight preference to low-rainfall areas

    // It should only appear in very hot areas
    // Temperature is in Celsius
    // 50C is 122F
    // 40C is 104F
    // 30C is 86F
    // 20C is 68F
    // 10C is 50F
    // 0C is 32F

    public override float GetScore(Tile tile, int tileID) {
      // Exclude water-covered tiles
      if (tile.WaterCovered) {
        return -100f;
      }

      if (tile.temperature < 10f) {
        return -100f;
      }

      // It spawns there the rainfall is between 300f and 450f
      if (tile.rainfall < 300f || tile.rainfall > 450f) {
        return 0f;
      }

      // It spawns there the elevation is higher than 1600f
      if (tile.elevation < 1600f) {
        return 0f;
      }

      // Casting to F for higher values
      float asFahrenheit = (tile.temperature * (9 / 5)) + 32f;

      return Math.Max(
        -100f, // min
        Math.Min(
          // The hotter == the more likely to spawn
          // PLUS a bonus of 10f
          asFahrenheit + 10f,
          100f // max
        )
      );
    }
  }
}
