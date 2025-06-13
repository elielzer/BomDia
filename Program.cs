using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomDia
{
     class Program
    {
        public static BomDia Bomdia { get; set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        //static void Main()
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bomdia = new BomDia();
            Application.Run(Bomdia);
            
        }
    }
}
