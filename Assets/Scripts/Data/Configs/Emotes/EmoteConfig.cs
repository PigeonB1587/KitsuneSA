namespace App.Data
{
    [System.Serializable]
    public class EmoteConfig : BaseItemConfig
    {
        public string emoteSpineKey { get; set; }
        public bool loops { get; set; }
        public bool allowSkeletonFlip { get; set; }

        public string playMusic { get; set; }
        public bool hasMusic { get; set; }
        public bool isDance { get; set; }

        public string petAnim { get; set; }
        public bool hasVoice { get; set; }
        public bool allowMovement { get; set; }
        public float moveTolerance { get; set; }
        public string playMusicRare { get; set; }
        public string emoteSpineKeyWalk { get; set; }
        public string emoteSpineKeyInitial { get; set; }
        public string playMusicIntro { get; set; }
        public bool allowMovementNeedWalkAnim { get; set; }
        public bool faceMovement { get; set; }
    }

    public static partial class Utils
    {

    }
}
