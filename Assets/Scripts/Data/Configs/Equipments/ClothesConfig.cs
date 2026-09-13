using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class ClothesConfig : BaseEquipmentConfig<ClothesSpinePart> { }

    [System.Serializable]
    public class ClothesSpinePart : BaseSpinePart
    {
        public bool includeFront { get; set; }
    }
}
