using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Globalization;

namespace ImageShrinker
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static string Language;
        /// <summary>
        /// コマンドラインを処理するスタートアップ
        /// </summary>
        void app_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 0) return;
            foreach (string argument in e.Args)
            {
                if (argument.Contains("-E") || argument.Contains("-e"))
                {
                    Language = "English";
                    //vga.Save();
                }
                else if (argument.Contains("-J") || argument.Contains("-j"))
                {
                    Language = "Japanese";
                }
            }
        }
    }
}
