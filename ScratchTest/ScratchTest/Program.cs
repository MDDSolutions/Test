using MDDDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScratchTest
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
            DBEngine.Default = new DBEngine("server=MDD-SQL2014;database=MDDSolutions;Trusted_Connection=true;", "MDDScratchTest");
            DBEngine.Default.AllowAdHoc = true;
            Application.Run(new Form1());
        }
    }
}
