using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{     //--Author's name:Wen Xu
    //--Author’s student number:301098127,
    //--Date last Modified:20,August,2020,
    //--Program description:1.0.0 version is to build a UI and display character builder.
    //--Revision History:1.0.0
    public static class Program
    {
        public static Character character;
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static RaceAndClassForm raceAndClassForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            character = new Character();
            generateNameForm = new GenerateNameForm();
            Application.Run(new SplashForm());
        }
    }
}
