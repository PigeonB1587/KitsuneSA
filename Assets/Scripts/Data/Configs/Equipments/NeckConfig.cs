using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class NeckConfig : BaseItemConfig
    {
        public List<NeckSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class NeckSpinePart : BaseSpinePart { }
}
