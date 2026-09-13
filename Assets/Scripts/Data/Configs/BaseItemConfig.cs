using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class BaseItemConfig
    {
        public string inventoryID { get; set; }
        public string icon { get; set; }
    }

    [System.Serializable]
    public class BaseEquipmentConfig<TSpinePart> : BaseItemConfig
        where TSpinePart : BaseSpinePart, new()
    {
        public List<TSpinePart> spineParts { get; set; } = new();
        public bool useCosmeticsAnimTrack { get; set; }
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
