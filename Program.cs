using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomDia
{
     class Program
    {
        public static char CharValue;

        public static BomDia Bomdia { get; set; }
        public static Pad pad { get; set; }
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        //static void Main()
        // Definição do delegate

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bomdia = new BomDia();    

            Application.Run(Bomdia);
        }
        public static int DiaBomDiaX = 0; public static int DiaBomDiaY = 0;
    }        
}
