using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Text_Converter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
        public static string CapitalizeWord(string value)
        {
            //var output = new StringBuilder();
            ////output.Insert()
            //tolower
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
       
    }
    

}
