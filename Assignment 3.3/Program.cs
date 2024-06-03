using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            /*Windows form assignments

            Use different controls on windows forms and change their properties (do not submit this assignment)
            Create a structure : Student with fields like studid, firstname, lastname, address,monthofadmission,grade to hold character.
            Create a list of students and perform following operations in windows application:

            1. add new records,
            2. delete record and
            3. display them in grid.

            Monthofadmission should be enum.*/


        }
    }
}
