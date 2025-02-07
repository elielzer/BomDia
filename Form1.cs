﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.Xml.Schema;
using System.Drawing.Printing;


namespace BomDia
{
    public partial class BomDia : Form
    {
        int LarguraForm = 0;
        int AlturaForm = 0;
        int Xloc = 0;
        int Yloc = 0;
        int LarguraReduzida = 0;
        //int LarguraDateTimeePiker1 = 0;
        int AlturaReduzida = 0;
        int NRow = 0; // Usado na contagem de Rows no dadagridview1
        DateTime DataSemana ;
        string BancoDados =
            "C:/Users/elielzer/Documents/Bom-Dia/XmlDoc.xml";
        public BomDia()
        {
            InitializeComponent();
        }

        public void BomDia_Load(object sender, EventArgs e)
        {

            TarefasDataSet.ReadXml(BancoDados, XmlReadMode.ReadSchema);
            //

            // Como está a janela do aplicativo 
            DataHoje.Visible = true;
            DataHoje.Text = DateTime.Today.ToShortDateString();

            Xloc = Location.X;
            Yloc = Location.Y;
            LarguraForm = Width;
            AlturaForm = Height;

            // Layout mini janela
            FormBorderStyle = FormBorderStyle.None;
            StatusStripBomDia.Visible = false;
            LarguraReduzida =
                (int)(((ushort)dateTimePicker1.Width) * 1.73);
            AlturaReduzida =
                (int)(((ushort)dateTimePicker1.Height) * 1.1);
            Width = LarguraReduzida;
            this.BackColor = Color.Black;
            // Transição altura da mini janela


            //Height = AlturaReduzida + DataHoje.Height;
            //splitContainer2.Visible = false;
            splitContainer1.Panel2Collapsed = true;
            Height = AlturaReduzida;

            Height = AlturaReduzida + DataHoje.Height;
            timer2.Enabled = true;
            timer2.Stop();
            timer2.Start();

            // Mostra a data do dia



            Location = new Point(1050, 0);

            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
                      
            //
            DateTime DateObject = Convert.ToDateTime(ListaDeDatas.Text);
            //Str = @"QUANDO = " + DateObject.Day + "/" + DateObject.Month + "/" + DateObject.Year;
            TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'",ListaDeDatas.Text);
            //
            string SemanaComMaiuscula;
            SemanaComMaiuscula = DateTime.Today.ToString("ddd");
            SemanaComMaiuscula = SemanaComMaiuscula[0].ToString().ToUpper() +
                SemanaComMaiuscula[1].ToString() + SemanaComMaiuscula[2].ToString();
            SemanaToolStripButton.Text = string.Concat(".", SemanaComMaiuscula);

            this.BackColor = Color.Black;
            
        }

        private void CortinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;

            StatusStripBomDia.Visible = true;
            ActiveForm.Location = new Point(Xloc, Yloc);
            Width = LarguraForm;
            Height= AlturaForm;
            this.BackColor = Color.Gray;
            this.WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
            ControlBox = true;
            //Refresh();
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
                //splitContainer2.Visible = false;
                StatusStripBomDia.Visible = false;
                this.WindowState = FormWindowState.Normal;
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
                MSGtoolStripStatusLabel.Text = "Anexada a tarefa no arquivo XML " + 
                    DateTime.Now.ToString();
                
                this.label1.Image = global::BomDia.Properties.Resources.CLIP07;
            }
            catch
            {
            }
        }
        // Entrada de novo registro, manualmente, ao arquivo XML ----------------
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            DetalhePorQue.Visible = true ;
            DetalheQuando.Visible = true ;
            DetalhePorQue.Text = "A" ;
            DetalheQuando.Text = DateTime.Today.ToShortDateString();
            DetalhePorQue.Visible = false;
            DetalheQuando.Visible = false;
            ActiveControl = OQuePretendido;
            MSGtoolStripStatusLabel.Text = "Esboço...";
            this.label1.Image = global::BomDia.Properties.Resources.NEW;
            label1.Text = "Escrever item";
            label5.Text = "";
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Enabled = true;
        }


        private void AbrirToolStripButtonGerenciar_Click(object sender, EventArgs e)
        {
            //GroupBox1.Enabled = true;
            tableLayoutPanel6.Enabled = true;
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
                //MSGtoolStripStatusLabel.Text = "Data futura";
                DiaBomDiaLabel.Text = "Data é futura";
            }
            if (DataPara < DataHoje)
            {
                //MSGtoolStripStatusLabel.Text = "Data passada";
                DiaBomDiaLabel.Text = "Data é passada";
            }
            if (DataPara == DataHoje)
            {
                MSGtoolStripStatusLabel.Text =
                    "Arquivo de dados: " + BancoDados;
                DiaBomDiaLabel.Text = "Data é hoje";
            }
        }
        //listbox
        private void Timer1_Tick(object sender, EventArgs e)
        {

            dateTimePicker1.ResetText();
            //SemanaToolStripButton.Text = DateTime.Today.ToString("ddd");
            string SemanaComMaiuscula;
            SemanaComMaiuscula = DateTime.Today.ToString("ddd");
            SemanaComMaiuscula = SemanaComMaiuscula[0].ToString().ToUpper() +
                SemanaComMaiuscula[1].ToString() + SemanaComMaiuscula[2].ToString() ;
            SemanaToolStripButton.Text =  string.Concat( ".", SemanaComMaiuscula) ;
        }

        // Pré inserir um registro existente para nova data
        private void MigrarToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NRow; i++)
            {
                
                switch (DataGridView1.Rows[i].Cells[7].Value)
                {
                    case  true:
                        
                        DataRow Row;
                        Row = BomDiaTarefas.NewRow();
                        Row["QUANDO"] = DateTime.Today.ToShortDateString();
                        Row["OQUE"] = DataGridView1.Rows[i].Cells[1].Value; //4ª col
                        Row["PORQUE"] = DataGridView1.Rows[i].Cells[4].Value; //5ª col


                        Row["PESO"] = DataGridView1.Rows[i].Cells[5].Value; //6ª col
                        Row["CRITÉRIO"] = DataGridView1.Rows[i].Cells[6].Value; //7ª col
                        Row["DIAMARCADO"] = DataGridView1.Rows[i].Cells[3].Value; //3ª col

                        // Índice
                        BomDiaTarefas.Rows.Add(Row);
                        MSGtoolStripStatusLabel.Text =
                            "Migrado IND(" + DataGridView1.Rows[i].Cells[0].Value + ")" + " para hoje";
                        
                        break;
                    case  false:
                        ;
                        break;
                }
                
             }

            

        }

        public void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu suspenso para o comando Voltar para formato reduzido.

            StatusStripBomDia.Visible = false;
            this.WindowState = FormWindowState.Normal;
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


        private void DataGridView1_Enter(object sender, EventArgs e)
        {
            MSGtoolStripStatusLabel.Text = "Bom dia. Arquivo de dados: " + TarefasDataSet.Namespace;
            NRow = DataGridView1.RowCount-1;
            this.Text = Application.ProductName + " " + NRow.ToString() + "Tasks";
        }

        private void hojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeDatas.Text = DateTime.Today.ToShortDateString();
        }

        //-----------------------------------------------------------------------------
        // Escreve as mudanças dinâmicas de data de execução de tarefas para a interface
        //-----------------------------------------------------------------------------
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            //this.label1.Image = null; // imagem ao registro atual não mais existe
            this.label1.Image = global::BomDia.Properties.Resources.Edit1;
            this.label1.Text = "Editar item";
            if (DataGridView1.CurrentRow == null) //quando a posição está em linha nova
            {
                try
                {
                    MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                      lower: DateTime.Today,
                      upper: DateTime.Today); //marcação padrão na data de hoje
                    
                    label5.Text =  "(em branco)".ToUpper(); //texto fantasia
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
            
            if (DataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                {
                    try
                    {
                        MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                          lower: DateTime.Today,
                          upper: DateTime.Today);
                        if (DataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                        {
                            label5.Text = "agenda do dia";
                            return;
                        }
                        else
                        {
                            DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
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
                else  // Quando o registro já existe fazer isso.
                {
                    //
                    try
                    {
                        MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                          lower: (DateTime)DataGridView1.CurrentRow.Cells[3].Value,
                          upper: (DateTime)DataGridView1.CurrentRow.Cells[3].Value);
                        DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
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
                    catch (Exception)
                    {
                    }
                }
        }

        private void SemanaToolStripButton_MouseHover(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            
            dateTimePicker1.Font = new Font("Agency FB", 10F, FontStyle.Regular);

        }

        private void SemanaToolStripButton_MouseLeave(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Calibri", 22F, FontStyle.Bold);

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //splitContainer1.Panel2Collapsed = true;
            Height = AlturaReduzida;
            DataHoje.Visible = false;
            timer2.Stop();

            // definir a propriedade de menucontextstrip
            dateTimePicker1.ContextMenuStrip = ChaveadorContextMenuStrip;
        }

        private void splitContainer6_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarefasBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            label1.Text = "Escrever item";
            this.label1.Image = global::BomDia.Properties.Resources.NEW;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {
            this.Text = Application.ProductName  ;
        }
        // Manipular a operação de saída de relatório
        private void PrintDataGridView(DataGridView dataGridView)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => PrintPageHandler(sender, e, dataGridView);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            printPreviewDialog.Show();
        }
        
        // Constrói o método de saída de relatório
        private void PrintPageHandler(object sender, PrintPageEventArgs e, DataGridView dataGridView)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            bool morePagesToPrint = false;
            int rowHeight = 0;
            int columnWidth = 0;
            int cellHeight = 0;
            int cellWidth = 0;
            int currentY = topMargin;

            // Print the header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                columnWidth = column.Width;
                e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, Brushes.Black, leftMargin, currentY);
                leftMargin += columnWidth;
            }
            // 2*rowHeight
            currentY += 20;
            
            // Print the rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                leftMargin = e.MarginBounds.Left;
                rowHeight = row.Height;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cellWidth = cell.Size.Width;
                    cellHeight = cell.Size.Height;
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), 
                        cell.InheritedStyle.Font, Brushes.Black, leftMargin, currentY);
                    leftMargin += cellWidth;
                }
                currentY += rowHeight;

                // Check if we need to print more pages
                if (currentY + rowHeight > e.MarginBounds.Bottom)
                {
                    morePagesToPrint = true;
                    break;
                }
            }

            e.HasMorePages = morePagesToPrint;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDataGridView(DataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void BomDia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Assuming you have a DataGridView named dataGridView1
            // and a DataTable named dataTable
            DataView dataView = new DataView(BomDiaTarefas);
            dataView.RowFilter = "DIAMARCADO = '" + maskedTextBoxDia.Text +"'";
            DataGridView1.DataSource = dataView;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = TarefasBindingSource;
        }
    }


}
