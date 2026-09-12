using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class ClothesConfig : BaseItemConfig
    {
        public List<SpinePart> spineParts { get; set; } = new List<SpinePart>();
        public bool hideHair1 { get; set; }
        public bool hideHair2 { get; set; }
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class SpinePart
    {
        public string skin { get; set; }
        public string slot { get; set; }
        public string template { get; set; }
        public string region { get; set; }
        public bool? includeFront { get; set; }
        public string regionCut { get; set; }
    }

    public static partial class Utils
    {

    }
}
