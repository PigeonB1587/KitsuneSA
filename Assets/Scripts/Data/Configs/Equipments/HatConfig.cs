using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class HatConfig : BaseEquipmentConfig<HatSpinePart>
    {
        public bool hideHair1 { get; set; }
        public bool hideHair2 { get; set; }
    }

    [System.Serializable]
    public class HatSpinePart : BaseSpinePart
    {
        public string regionCut { get; set; }
    }

    public static partial class Utils
    {
        public static string GetRegion(this HatSpinePart hatSpinePart, CharacterConfig forCharacter) =>
            hatSpinePart.regionCut != null && forCharacter.needsCutHats
                ? hatSpinePart.regionCut
                : forCharacter.customShiaHeadband && hatSpinePart.region == "costumes/hat/headband_shia"
                    ? "costumes/hat/earband"
                    : hatSpinePart.region;
    }
}
