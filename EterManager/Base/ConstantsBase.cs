﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EterManager.Base
{
    class ConstantsBase
    {
        // Constant values
        internal static readonly string AppDataPath = "AppData/";
        internal static readonly string ProfilesPath = AppDataPath + "Profiles/";
        internal static readonly string SettingsFilePath = AppDataPath + "settings.json";
        internal static readonly string UpdatePath = "tmp/update.zip";
        internal static readonly string ApiUrl = "http://139.59.148.154:8080/";
        internal static readonly byte[] LzoFourCc = { 77, 67, 79, 90 }; //MCOZ
        internal static readonly byte[] EterFourCc = { 69, 80, 75, 68 }; //EPKD

        // App-wide settings
        internal static int MaxSimFiles = 0;

    }
}
