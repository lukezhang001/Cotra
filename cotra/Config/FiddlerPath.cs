using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cotra.Config
{
    internal static class FiddlerPath
    {
        public static string FiddlerInstallPath { get; set; }

        public static string FiddlerInstallDir { get; set; }

        public static string CotraDir { get; set; }

        public static string CotraLogDir { get; set; }

        public static string RuleFilePath { get; set; }


        static FiddlerPath()
        {
            FiddlerInstallPath = "";
            FiddlerInstallDir = "";
            CotraDir = "";
            CotraLogDir = "";
            RuleFilePath = "";
        }

        public static void InitPath()
        {
            FiddlerInstallPath = Application.ExecutablePath;
            FiddlerInstallDir = Path.GetDirectoryName(FiddlerInstallPath);

            //CotraDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Cotra");
            CotraDir = FiddlerInstallDir + "\\Scripts\\Cotra";
            //CotraLogDir = CotraDir + @"\Log";

            RuleFilePath = CotraDir + @"\CotraRule.xml";
        }
    }
}
