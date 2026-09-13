using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class BeardConfig : BaseItemConfig
    {
        public List<BeardSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class BeardSpinePart : BaseSpinePart { }
}
