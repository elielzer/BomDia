using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BomDia
{
    public partial class Pad : Form
    {
        public event Action<object, string> Portal;
        public Pad()
        {
            InitializeComponent();
        }

        private void Pad_MouseLeave(object sender, EventArgs e)
        {
            if(FormBorderStyle != FormBorderStyle.None)
            { FormBorderStyle = FormBorderStyle.None; }
        }

        private void handleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.FixedSingle)
            { FormBorderStyle = FormBorderStyle.FixedSingle; }
        }

        public void button2_Clickado(BomDia bomDia, int Sinal )
        {
            try
            {
                DateTime datetime = Convert.ToDateTime(VariaveisGlobais.ListaDeDatasText);
                datetime = datetime.AddDays(Sinal);
                bomDia.ListaDeDatas.Text = datetime.ToShortDateString();
            }
            catch
            {
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime = 
                Convert.ToDateTime(VariaveisGlobais.ListaDeDatasText);
            datetime = datetime.AddDays(+1);
            VariaveisGlobais.ListaDeDatasText = datetime.ToShortDateString();
            //bomDia.ListaDeDatas.Text = datetime.ToShortDateString();
            Portal?.Invoke(this, VariaveisGlobais.ListaDeDatasText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datetime = Convert.ToDateTime(VariaveisGlobais.ListaDeDatasText);
            datetime = datetime.AddDays(-1);
            VariaveisGlobais.ListaDeDatasText = datetime.ToShortDateString();
            //bomDia.ListaDeDatas.Text = datetime.ToShortDateString();
            Portal?.Invoke(this, VariaveisGlobais.ListaDeDatasText);
        }
    }
}
public static class VariaveisGlobais
{
    //public static int ContadorGlobal = 0;
    // Armazena a data para o interface entre janelas
    public static string ListaDeDatasText = "";
}