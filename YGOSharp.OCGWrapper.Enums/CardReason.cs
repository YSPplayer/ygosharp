namespace YGOSharp.OCGWrapper.Enums
{
    public enum CardReason
    {
        Destroy = 1,
        Release = 2,
        Temporary = 4,
        Material = 8,
        Summon = 16,
        Battle = 32,
        Effect = 64,
        Cost = 128,
        Adjust = 256,
        LostTarget = 512,
        Rule = 1024,
        SpecialSummon = 2048,
        Dissummon = 4096,
        Flip = 8192,
        Discard = 16384,
        RecoverDamage = 32768,
        RecoverLife = 65536,
        Return = 131072,
        Fusion = 262144,
        Synchro = 524288,
        Ritual = 1048576,
        Xyz = 2097152,
        Replace = 16777216,
        Draw = 33554432,
        Redirect = 67108864,
        Reveal = 134217728,
        Link = 268435456,
        LostOverlay = 536870912
    }
}
