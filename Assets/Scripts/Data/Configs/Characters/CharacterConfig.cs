namespace App.Data
{
    [System.Serializable]
    public class CharacterConfig : BaseItemConfig
    {
        public string spineSkin { get; set; }
        public string spineBaseSkin { get; set; }

        public string lockedIcon { get; set; }
        public string headIcon { get; set; }
        public string parentChar { get; set; }

        public bool needsCutHats { get; set; }
        public bool customShiaHeadband { get; set; }
    }

    public static partial class Utils
    {
        public static string GetSkin(this CharacterConfig forCharacter, string skin)
            => skin == "#BASE_ANIMAL" ? forCharacter.spineBaseSkin : skin;
    }
}
