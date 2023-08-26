using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace BomDia
{
    public partial class BomDia : Form
    {
        int LarguraForm = 0;
        int AlturaForm = 0;
        int Xloc = 0;
        int Yloc = 0;
        int LarguraReduzida = 0;
        int LarguraDateTimeePiker1 = 0;
        int AlturaReduzida = 0;
        DateTime DataSemana ;
        string BancoDados = "C:/Users/elielzer/Documents/Bom-Dia/XmlDoc.xml";
        public BomDia()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {

        }

        public void BomDia_Load(object sender, EventArgs e)
        {

            TarefasDataSet.ReadXml(BancoDados, XmlReadMode.ReadSchema);
            //

            // Estilo de Layout janela expandida armazenado 

            Xloc = Location.X;
            Yloc = Location.Y;
            LarguraForm = Width;
            AlturaForm = Height;
            LarguraDateTimeePiker1 = dateTimePicker1.Width;

            // Layout mini janela inicializado
            splitContainer2.Visible = false;
            StatusStripBomDia.Visible = false;
            LarguraReduzida = (int)(((ushort)dateTimePicker1.Width) * 1.73);
            AlturaReduzida = (int)(((ushort)dateTimePicker1.Height) * 1.1);
            Width = LarguraReduzida;

            // Trasição altura da mini janela

            Height = AlturaReduzida + DataHoje.Height;
            timer2.Enabled = true;
            timer2.Stop();
            timer2.Start();

            // Mostra a data do dia
            DataHoje.Visible = true;
            DataHoje.Text = DateTime.Today.ToShortDateString();

            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1050, 0);

            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
                      
            //
            DateTime DateObject = Convert.ToDateTime(ListaDeDatas.Text);
            //Str = @"QUANDO = " + DateObject.Day + "/" + DateObject.Month + "/" + DateObject.Year;
            TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'",ListaDeDatas.Text);
            //
            SemanaToolStripButton.Text = DateTime.Today.ToString("ddd");
            this.BackColor = Color.Black;
        }

        private void CortinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Visible = true;
            StatusStripBomDia.Visible = true;
            ActiveForm.Location = new Point(Xloc, Yloc);
            Width = LarguraForm;
            Height= AlturaForm;
            this.BackColor = Color.Gray;
            ControlBox = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Refresh();
            cortinaToolStripMenuItem.Enabled = false;
            //atualiza data hoje
            if (ListaDeDatas.Text == DateTime.Today.ToShortDateString())
            {
            }
            else { 
               ListaDeDatas.Text = DateTime.Today.ToShortDateString();
            }
            this.Tag = "Max";
        }
        public enum ValorTag
        {
            Min 
        }
        public void BomDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)27 )
            {
                var EstaTag = this.Tag;
                switch (EstaTag)
                {
                    case "Min":
                        return;

                }

                // Menu suspenso para o comando Voltar.
                splitContainer2.Visible = false;
                StatusStripBomDia.Visible = false;
                FormBorderStyle = FormBorderStyle.None;
                Xloc = Location.X;
                Yloc = Location.Y;
                LarguraForm = Width;
                AlturaForm = Height;
                Width = LarguraReduzida;
                Height = (int)(((ushort)dateTimePicker1.Height) * 1.1);
                this.BackColor = Color.Black;
                Location = new Point(1100, 0);
                cortinaToolStripMenuItem.Enabled = true;
                this.Tag = "Min";
            };
            
        }

        private void SalvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                TarefasBindingSource.EndEdit();
                TarefasDataSet.AcceptChanges();

                //
                if (TarefasDataSet == null) { return; }

                // Create a file name to write to.
                string filename = "C:/Users/elielzer/Documents/Bom-Dia/XmlDoc.xml";

                // Create the FileStream to write with.
                System.IO.FileStream stream = new System.IO.FileStream
                    (filename, System.IO.FileMode.Create);

                // Create an XmlTextWriter with the fileStream.
                System.Xml.XmlTextWriter xmlWriter =
                    new System.Xml.XmlTextWriter(stream,
                    System.Text.Encoding.Unicode);

                // Write to the file with the WriteXml method.
                TarefasDataSet.WriteXml(xmlWriter);
                xmlWriter.Close();
                MSGtoolStripStatusLabel.Text = "Anexada a tarefa no arquivo XML " + DateTime.Now.ToString();
                
                this.label1.Image = null;
            }
            catch
            {
            }
        }
        // Entrada de novo registro, manualmente, ao arquivo XML ----------------
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DetalhePorQue.Visible = true;
            DetalheQuando.Visible = true;
            DetalhePorQue.Text = "A";
            DetalheQuando.Text = DateTime.Today.ToShortDateString();
            DetalhePorQue.Visible = false;
            DetalheQuando.Visible = false;
            ActiveControl = OQuePretendido;
            MSGtoolStripStatusLabel.Text = "Esboço...";
            this.label1.Image = global::BomDia.Properties.Resources.NEW;
            
            label5.Text = "";
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            //GroupBox1.Enabled = true;
            PainelPrincipal.Enabled = true;
        }


        private void AbrirToolStripButtonGerenciar_Click(object sender, EventArgs e)
        {
            //GroupBox1.Enabled = true;
            PainelPrincipal.Enabled = true;
            BindingNavigatorNovo.Enabled = true;
            BindingExclui.Enabled = true;
            BindingNavigatorSalva.Enabled = true;
            //altera a imagem da picture
            this.PictureBox1.Image = global::BomDia.Properties.Resources.LIGHTON;
            PictureBox1.Visible = true; //figura indica modo gerenciamento
            bindingNavigator1.Visible = false;
            
        }


        private void CheckBoxIntegrador_Click(object sender, EventArgs e)
        {
            if (CheckBoxIntegrador.Checked == true)
            {
                TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'", ListaDeDatas.Text);
            }
            else
            {
                TarefasBindingSource.Filter = "";
            }
        }

        private void ListaDeDatas_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime DataHoje = DateTime.Today;
            DateTime DataPara = Convert.ToDateTime(ListaDeDatas.SelectedItem);
            if (CheckBoxIntegrador.Checked)
            {
                TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'", ListaDeDatas.Text);
            }
            //
            if (DataPara > DataHoje)
            {
                MSGtoolStripStatusLabel.Text = "Data futura";
            }
            if (DataPara < DataHoje)
            {
                MSGtoolStripStatusLabel.Text = "Data passada";
            }
            if (DataPara == DataHoje)
            {
                MSGtoolStripStatusLabel.Text = "Hoje. || Arquivo de dados: " + BancoDados;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Alô mundo");
             dateTimePicker1.ResetText();
            //dateTimePicker2.ResetText();
        }

        private void MigrarToolStripButton_Click(object sender, EventArgs e)
        {
            DataRow Row;
            Row = BomDiaTarefas.NewRow();
            Row["QUANDO"] = DateTime.Today.ToShortDateString();
            Row["OQUE"] = DataGridView1.CurrentRow.Cells[3].Value; //4ª col
            Row["PORQUE"] = DataGridView1.CurrentRow.Cells[4].Value; //5ª col


            Row["PESO"] = DataGridView1.CurrentRow.Cells[5].Value; //6ª col
            Row["CRITÉRIO"] = DataGridView1.CurrentRow.Cells[6].Value; //7ª col
            Row["DIAMARCADO"] = DataGridView1.CurrentRow.Cells[2].Value; //3ª col

            // Índice
            BomDiaTarefas.Rows.Add(Row);
            MSGtoolStripStatusLabel.Text =
                "Migrado IND(" + DataGridView1.CurrentRow.Cells[0].Value + ")" + " para hoje";
        }

        public void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu suspenso para o comando Voltar.
            splitContainer2.Visible = false;
            StatusStripBomDia.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            Xloc = Location.X;
            Yloc = Location.Y;
            LarguraForm = Width;
            AlturaForm = Height;
            Width = LarguraReduzida;
            Height = (int)(((ushort)dateTimePicker1.Height) * 1.1);
            this.BackColor = Color.Black;
            Location = new Point(1100, 0);
            cortinaToolStripMenuItem.Enabled = true;
        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            //dateTimePicker1.Width = (int)(LarguraDateTimeePiker1 * 1.35);
            //dateTimePicker1.Height = Height;
            //dateTimePicker1.Font = new Font((string)dateTimePicker1.Font.Name,
            //    13, dateTimePicker1.Font.Style, (GraphicsUnit)dateTimePicker1.Font.Unit);
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
        }


        private void DataGridView1_Enter(object sender, EventArgs e)
        {
            MSGtoolStripStatusLabel.Text = "Bom dia. Arquivo de dados: " + TarefasDataSet.Namespace;
        }

        private void hojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
        }

        //-----------------------------------------------------------------------------
        // Escreve as mudanças dinâmicas de data de execução de tarefas para a iterface
        //-----------------------------------------------------------------------------
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //PictureBox1.Visible = false;

            this.label1.Image = null; // anula a imagem indicadora de inclusão

            if (DataGridView1.CurrentRow == null) //quando a posição está em linha nova
            {
                try
                {
                    MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                      lower: DateTime.Today,
                      upper: DateTime.Today); //marcação padrão na data de hoje
                    
                    label5.Text =  "(em branco)".ToUpper(); //texto fantasia
                    // new SelectionRange(
                    //lower: (DateTime)DataGridView1.CurrentRow.Cells[6].Value,
                    //upper: (DateTime)DataGridView1.CurrentRow.Cells[6].Value);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return; } // Finaliza em seguida aqui
            //
            else
            // Redefine o texto atual da barra de status
            MSGtoolStripStatusLabel.Text = "Indexador: " + DataGridView1.CurrentRow.Cells[0].Value;

                if (DataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    try
                    {
                        MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                          lower: DateTime.Today,
                          upper: DateTime.Today);
                        if (DataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            label5.Text = "agenda do dia";
                            return;
                        }
                        else
                        {
                            DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[2].Value;
                            if (DataSemana == DateTime.Today)
                            {
                                label5.Text = "Hoje";
                                return;
                            }
                            else
                            {
                                label5.Text = "";
                            }
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return; // finaliza se erro
                }
                else  // O registro é existente
                {
                    //
                    try
                    {
                        MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                          lower: (DateTime)DataGridView1.CurrentRow.Cells[2].Value,
                          upper: (DateTime)DataGridView1.CurrentRow.Cells[2].Value);
                        DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[2].Value;
                        //label5.Text =  DataSemana.DayOfWeek.ToString();
                        //
                        if (DataSemana == DateTime.Today)
                        {
                            label5.Text = "Previsto para hoje";
                            return;
                        }
                        else
                        {

                            switch (DataSemana.DayOfWeek)
                            {
                                case DayOfWeek.Monday:
                                    label5.Text =  "segunda-feira".ToUpper();
                                    break;

                                case DayOfWeek.Tuesday:
                                    label5.Text ="terça-feira".ToUpper();
                                    break;

                                case DayOfWeek.Wednesday:
                                    label5.Text = "quarta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Thursday:
                                    label5.Text = "quinta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Friday:
                                    label5.Text = "sexta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Saturday:
                                    label5.Text = "sábado".ToUpper();
                                    break;
                                case DayOfWeek.Sunday:
                                    label5.Text = "domingo".ToUpper();
                                    break;
                                default:
                                    label5.Text = "Não definido".ToUpper();
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
        }

        private void SemanaToolStripButton_MouseHover(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            
            dateTimePicker1.Font = new Font("Agency FB", 10F, FontStyle.Regular);
            //DataHoje.Location = new Point(0, 0);
            //DataHoje.Visible = true;
            //DataHoje.Text = dateTimePicker1.Text;
        }

        private void SemanaToolStripButton_MouseLeave(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Agency FB", 21.75F, FontStyle.Bold);
            //DataHoje.Visible = false;
        }

        private void BindingNavigatorSalva_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorSemana_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Height = AlturaReduzida;
            DataHoje.Visible = false;
            timer2.Stop();

            // definir a propriedade de menucontextstrip
            dateTimePicker1.ContextMenuStrip = ChaveadorContextMenuStrip;
        }
    }

}
