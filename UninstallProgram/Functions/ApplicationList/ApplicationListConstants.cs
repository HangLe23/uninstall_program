/*
    Copyright (c) 2017 Marcin Szeniak (https://github.com/Klocman/)
    Apache License Version 2.0
*/

using System.Drawing;
using UninstallProgram.Properties;
using UninstallTools;

namespace UninstallProgram.Functions.ApplicationList
{
    internal static class ApplicationListConstants
    {
        public static ApplicationListColors Colors => Settings.Default.MiscColorblind ? ApplicationListColors.ColorBlind : ApplicationListColors.Normal;

        public static Color GetApplicationTreemapColor(ApplicationUninstallerEntry entry)
        {
            if (entry.UninstallerKind == UninstallerType.WindowsFeature)
                return Colors.WindowsFeatureColor;

            if (entry.UninstallerKind == UninstallerType.StoreApp)
                return Colors.WindowsStoreAppColor;

            if (entry.IsOrphaned)
                return Colors.UnregisteredColor;

            if (!entry.IsValid)
                return Colors.InvalidColor;

            return Color.White;
        }
    }
}