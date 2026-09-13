using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class GlassesConfig : BaseItemConfig
    {
        public List<GlassesSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class GlassesSpinePart : BaseSpinePart { }
}
