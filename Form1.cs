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
        DateTime DataSemana;
        public BomDia()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            
            //dateTimePicker1.Font = new Font((string)dateTimePicker1.Font.Name,
            //   18, dateTimePicker1.Font.Style, (GraphicsUnit)dateTimePicker1.Font.Unit);
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "HH:mm";
            //dateTimePicker1.Width = (int)(LarguraDateTimeePiker1);

        }

        private void BomDia_Load(object sender, EventArgs e)
        {
            TarefasDataSet.ReadXml("D:/NS/BD/XmlDoc.xml", XmlReadMode.ReadSchema);
            //
            StatusStripBomDia.Visible = false;
            //
            Xloc = Location.X;
            Yloc = Location.Y;
            LarguraForm = Width;
            AlturaForm = Height;
            LarguraDateTimeePiker1 = dateTimePicker1.Width;
            LarguraReduzida = (int)(((ushort)dateTimePicker1.Width) * 1.30);
            AlturaReduzida= (int)(((ushort)dateTimePicker1.Height) * 1.1);
            Width = LarguraReduzida;
            Height = AlturaReduzida;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1100, 0);
            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
            string Str = "QUANDO = ";
                      
            //
            DateTime DateObject = Convert.ToDateTime(ListaDeDatas.Text);
            Str = @"QUANDO = " + DateObject.Day + "/" + DateObject.Month + "/" + DateObject.Year;
            TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'",ListaDeDatas.Text);
            //
            SemanaToolStripButton.Text = DateTime.Today.ToString("ddd");
        }

        private void CortinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStripBomDia.Visible = true;
            ActiveForm.Location = new Point(Xloc, Yloc);
            Width = LarguraForm;
            Height= AlturaForm;
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
        }

        private void BomDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)27 )
            {
                StatusStripBomDia.Visible = false;
                //LarguraForm = Width;
                //AlturaForm = Height;
                FormBorderStyle = FormBorderStyle.None;
                //Width = (int)(((ushort)dateTimePicker1.Width) * 1.40);
                //Height = (int)(((ushort)dateTimePicker1.Height) * 1.1);
                //
                //Width = LarguraReduzida;
                //Height = (int)(((ushort)dateTimePicker1.Height) * 1.1);
                LarguraForm = Width;
                AlturaForm = Height;
                Width = LarguraReduzida;
                Height = AlturaReduzida;
                Location = new Point(1200, 0);
                cortinaToolStripMenuItem.Enabled = true;
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
                string filename = "D:/NS/BD/XmlDoc.xml";

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
                PictureBox1.Visible = false;
            }
            catch
            {
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DetalhePorQue.Visible = true;
            DetalheQuando.Visible = true;
            DetalhePorQue.Text = "A";
            DetalheQuando.Text = DateTime.Today.ToShortDateString();
            DetalhePorQue.Visible = false;
            DetalheQuando.Visible = false;
            ActiveControl = OQuePretendido;
            MSGtoolStripStatusLabel.Text = "Nova tarefa em esboço...";
            PictureBox1.Visible = true;
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
            //
            
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
                MSGtoolStripStatusLabel.Text = "Hoje";
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
            Row["OQUE"] = DataGridView1.CurrentRow.Cells[1].Value;
            Row["PORQUE"] = DataGridView1.CurrentRow.Cells[2].Value;


            Row["PESO"] = DataGridView1.CurrentRow.Cells[3].Value;
            Row["CRITÉRIO"] = DataGridView1.CurrentRow.Cells[4].Value;
            Row["DIAMARCADO"] = DataGridView1.CurrentRow.Cells[6].Value;
            
            BomDiaTarefas.Rows.Add(Row);
            MSGtoolStripStatusLabel.Text = "Migrado IND(" + DataGridView1.CurrentRow.Cells[5].Value + ")" + " para hoje";
        }

        private void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu suspenso para o comando Voltar.


            StatusStripBomDia.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            Xloc = Location.X;
            Yloc = Location.Y;
            LarguraForm = Width;
            AlturaForm = Height;
            Width = LarguraReduzida;
            Height = (int)(((ushort)dateTimePicker1.Height) * 1.1);
            
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
            MSGtoolStripStatusLabel.Text = "Bom dia.";
        }

        private void hojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
        }



        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            PictureBox1.Visible = false;
            if (DataGridView1.CurrentRow == null)
            {
                try
                {
                    MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                      lower: DateTime.Today,
                      upper: DateTime.Today);
                    
                    label5.Text =  "A definir";
                    // new SelectionRange(
                    //lower: (DateTime)DataGridView1.CurrentRow.Cells[6].Value,
                    //upper: (DateTime)DataGridView1.CurrentRow.Cells[6].Value);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return; }
            //
            else
            // Redefine o texto atual da barra de status
            MSGtoolStripStatusLabel.Text = "Indexador: " + DataGridView1.CurrentRow.Cells[5].Value;

            if (DataGridView1.CurrentRow.Cells[6].Value.ToString() == "")
               
            {
                try
                {


                    MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                      lower: DateTime.Today,
                      upper: DateTime.Today);
                    if (DataGridView1.CurrentRow.Cells[0].Value.ToString() == "")
                    {
                        label5.Text = "";
                        return;
                    }
                    else
                    {
                        DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[0].Value;
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


                return;
            }
            else
            {
                //
                try
                {

                    MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                      lower: (DateTime)DataGridView1.CurrentRow.Cells[6].Value,
                      upper: (DateTime)DataGridView1.CurrentRow.Cells[6].Value);
                    DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[6].Value;
                    //label5.Text =  DataSemana.DayOfWeek.ToString();
                    //
                    if (DataSemana == DateTime.Today)
                    {
                        label5.Text = "Hoje";
                        return;
                    }
                    else
                    {

                        switch (DataSemana.DayOfWeek)
                        {
                            case DayOfWeek.Monday:
                                label5.Text = "Segunda-feira";
                                break;

                            case DayOfWeek.Tuesday:
                                label5.Text = "Terça-feira";
                                break;

                            case DayOfWeek.Wednesday:
                                label5.Text = "Quarta-feira";
                                break;
                            case DayOfWeek.Thursday:
                                label5.Text = "Quinta-feira";
                                break;
                            case DayOfWeek.Friday:
                                label5.Text = "Sexta-feira";
                                break;
                            case DayOfWeek.Saturday:
                                label5.Text = "Sábado";
                                break;
                            case DayOfWeek.Sunday:
                                label5.Text = "Domingo";
                                break;
                            default:
                                label5.Text = "Não definido";
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
            
            //DataHoje.Location = new Point(0, 0);
            DataHoje.Visible = true;
            DataHoje.Text = dateTimePicker1.Text;
        }

        private void SemanaToolStripButton_MouseLeave(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            DataHoje.Visible = false;
        }

    }

}
