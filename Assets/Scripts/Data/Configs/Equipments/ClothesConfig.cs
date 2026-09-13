using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class ClothesConfig : BaseItemConfig
    {
        public List<ClothesSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class ClothesSpinePart : BaseSpinePart
    {
        public bool includeFront { get; set; }
    }

    [System.Serializable]
    public class BaseSpinePart
    {
        public string skin { get; set; }
        public string slot { get; set; }
        public string template { get; set; }
        public string region { get; set; }
    }
}
