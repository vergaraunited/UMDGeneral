﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UMDGeneral.Definitions
{
    public static class enums
    {
        public enum stopstate { Loaded, Complete, Incomplete, InProgress}

        public enum SPCmds { INSERTMANIFESTDETAILS, INSERTMANIFEST, GETAVAILABLEDRIVERS, GETDRIVERMANIFEST, GETTRUCKS, GETSTOPS, GETORDERS, GETMANIFEST, INSERTORDERDETAILS, INSERTORDER, INSERTORDEROPTIONS }

    }
}
