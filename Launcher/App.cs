using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KMCCC.Launcher;

namespace Obsidian.Launcher
{
    /// <summary>
    /// Minecraft启动类
    /// </summary>
    public partial class App
    {
        //String path = @"E:\Minecraft\.minecraft\versions\1.7.10";
        public static LauncherCore launcherCore = LauncherCore.Create(
            new LauncherCoreCreationOption(
                gameRootPath: @"E:\Minecraft\.minecraft",
                javaPath: @"C:\Program Files (x86)\Java\jre7\bin\javaw.exe",
                versionLocator: null
                ));
    }
}
