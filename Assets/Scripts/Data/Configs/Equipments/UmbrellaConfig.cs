using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class UmbrellaConfig : BaseItemConfig
    {
        public List<UmbrellaSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
    }

    [System.Serializable]
    public class UmbrellaSpinePart : BaseSpinePart { }
}
