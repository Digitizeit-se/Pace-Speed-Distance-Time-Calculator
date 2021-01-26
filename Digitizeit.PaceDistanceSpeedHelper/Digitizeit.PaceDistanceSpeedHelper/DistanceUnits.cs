using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Digitizeit.PaceDistanceSpeedHelper
{
    public enum DistanceUnitsMetrics
    {
        KiloMeter = 3,
        Mile = 4,
        Meter = 0,
        DeciMeter = -1,
        CentiMeter = -2,
        MilliMeter = -3,
        MicroMeter = -6,
        NanoMeter = -9,
        PicoMeter = -12,
        FemtoMeter = -15,
        AttoMeter = -18,
        ZeptoMeter = -21,
        YocToMeter = -24
    }

    public enum DistanceUnitsImperialUS
    {
        Mile = 63360,
        Yard = 36,
        Foot = 12,
        Inch = 0
    }
}