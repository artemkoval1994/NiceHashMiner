﻿using System;

namespace NHMCore.Notifications
{
    public enum NotificationsGroup
    {
        Misc,
        Market,
        Profit,
        MonitoringNvidiaElevate,
        EthlargementElevate,
        EthlargementNotEnabled,
        ConnectionLost,
        NoEnabledDevice,
        DemoMining,
        NoSma,
        [Obsolete]
        NoDeviceSelectedBenchmark,
        [Obsolete]
        NothingToBenchmark,
        FailedBenchmarks,
        NoSupportedDevices,
        MissingMiners,
        MissingMinerBins,
        [Obsolete]
        FailedVideoController,
        [Obsolete]
        WmiEnabled,
        [Obsolete]
        Net45,
        [Obsolete]
        BitOS64,
        NhmUpdate,
        NhmUpdateFailed,
        NhmWasUpdated,
        PluginUpdate,
        NvidiaDCH,
        WindowsDefenderException,
        ComputeModeAMD,
        LargePages,
        VirtualMemory,
        OpenClFallback,
        NoAvailableAlgorithms,
        LogArchiveUpload,
        MissingGPUs,
        NVMLInitFail,
        NVMLLoadFail,
        WrongChecksumBinary,
        MinerRestart,

    }
}
