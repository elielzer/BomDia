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
            this.TopMost = true; // Mantém o formulário sempre no topo

        }

        private void Pad_MouseLeave(object sender, EventArgs e)
        {
            if(FormBorderStyle != FormBorderStyle.None)
            { FormBorderStyle = FormBorderStyle.None; }

        }

        private void handleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.FixedToolWindow)
            { FormBorderStyle = FormBorderStyle.FixedToolWindow; }
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
        public void AtivarBomdia()
        {
            // Ativar o formulário principal de volta.
            if (Program.Bomdia != null && !Program.Bomdia.IsDisposed)
            {
                
                Program.Bomdia.TopMost = true;
                // Traz o formulário para frente
            }
        }


        private void Pad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) // Se tecla esc foi acionada
            {
                Program.CharValue = (char)27;

                this.Dispose();

                AtivarBomdia();
            }
        }

        private void Pad_Load(object sender, EventArgs e)
        {
            Portal +=
        (s, Stexto) => Program.Bomdia.ListaDeDatas.Text = Stexto; // Assina o evento
            
            
            

        }
    }
    
}
public static class VariaveisGlobais
{
    // Armazena a data para o interface entre janelas
    public static string ListaDeDatasText = "";
    public static string MeuDisplay = "";

}
