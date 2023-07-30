namespace YGOSharp.OCGWrapper.Enums
{
    public enum CardStatus
    {
        Disabled = 1,
        ToEnable = 2,
        ToDisable = 4,
        ProcComplete = 8,
        SetTurn = 16,
        NoLevel = 32,
        BattleResult = 64,
        SpSummonStep = 128,
        FormChanged = 256,
        Summoning = 512,
        EffectEnabled = 1024,
        SummonTurn = 2048,
        DestroyConfirmed = 4096,
        LeaveConfirmed = 8192,
        BattleDestroyed = 16384,
        CopyingEffect = 32768,
        Chaining = 65536,
        SummonDisabled = 131072,
        ActivateDisabled = 262144,
        EffectReplaced = 524288,
        FutureFusion = 1048576,
        AttackCanceled = 2097152,
        Initializing = 4194304,
        ToHandWithoutConfirm = 8388608,
        JustPos = 16777216,
        ContinuousPos = 33554432,
        Forbidden = 67108864,
        ActFromHand = 134217728,
        OppoBattle = 268435456,
        FlipSummonTurn = 536870912,
        SpSummonTurn = 1073741824
    }
}
