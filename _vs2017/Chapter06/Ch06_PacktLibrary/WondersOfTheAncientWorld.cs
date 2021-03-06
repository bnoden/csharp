﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {

        None = 1>>1,
        GreatPyramidOfGiza = 1<<0,
        HangingGardensOfBabylon = 1<<1,
        StatueOfZeusAtOlympia = 1<<2,
        TempleOfArtemisAtEphesus = 1<<3,
        MausoleumAtHalicarnassus = 1<<4,
        ColossusOfRhodes = 1<<5,
        LighthouseOfAlexandria = 1<<6

    }
}
