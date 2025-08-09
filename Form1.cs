using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.Xml.Schema;
using System.Drawing.Printing;
using BomDia;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.ComponentModel;




namespace BomDia
{
    public  partial class BomDia : Form
    {
        int LarguraForm = 0;
        int AlturaForm = 0;
        int Xloc = 0;
        int Yloc = 0;
        int LarguraReduzida = 0;

        Pad pad;

        //
        int AlturaReduzida = 0;
        int NRow = 0; // Usado na contagem de Rows no dadagridview1
        DateTime DataSemana ;
        string BancoDados =
            "C:/Users/elielzer/Documents/Bom-Dia/XmlDoc.xml";
        public const char Triang = '\u25E3';
        public BomDia()
        {
            InitializeComponent();

            Symbol.Text = Triang.ToString();//'\u25E3'.ToString();
            label4.Text = Triang.ToString();
            DiaBomDiaLabel.Text = "O Que Fazer ";

        }

        public void BomDia_Load(object sender, EventArgs e)
        {
            TarefasDataSet.ReadXml(BancoDados, XmlReadMode.ReadSchema);
            //
            sender = this.ListaDeDatas;
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
                (int)(((tableLayoutPanel2.Width * 1.03)));
            //(int)(((ushort)dateTimePicker1.Width) * 1.5);
            AlturaReduzida =
                (int)(tableLayoutPanel2.Height * 1.05);
            //(int)(((ushort)dateTimePicker1.Height) * 1.09);
            Width = LarguraReduzida;
            this.BackColor = Color.Black;

            // Transição altura da mini janela

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
            //Apresentar a janela principal padrão
            //
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

            //atualiza data padrão (data do dia)
            if (ListaDeDatas.Text == DateTime.Today.ToShortDateString())
            {
            }
            else { 
               ListaDeDatas.Text = DateTime.Today.ToShortDateString();
            }
            this.Tag = "Max";
            //DataGridView1.Focus();
        }
        public enum ValorTag
        {
            Min
        }
        public void BomDia_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar ==(char)27 )
            {
                // Zerar a variável global 
                Program.CharValue = (char)0;

                var EstaTag = this.Tag;
                switch (EstaTag)
                {
                    case "Min":
                        return;

                }

                if(pad !=null)
                { pad.Dispose(); }
                Program.Bomdia.TopMost = true;

                // Menu suspenso para o comando Voltar.

                StatusStripBomDia.Visible = false;
                this.WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                Xloc = Location.X;
                Yloc = Location.Y;
                LarguraForm = Width;
                AlturaForm = Height;
                Width = LarguraReduzida;
                Height = (int)(((ushort)dateTimePicker1.Height) * 1.05);
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
                
                this.PictureBoxEditar.Image = global::BomDia.Properties.Resources.CLIP07;
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
            this.PictureBoxEditar.Image = global::BomDia.Properties.Resources.NEW;
            label1.Text = "Novo item...";
            label5.Text = "";
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Enabled = true;
        }


        private void AbrirToolStripButtonGerenciar_Click(object sender, EventArgs e)
        {

            tableLayoutPanel6.Enabled = true;
            BindingNavigatorNovo.Enabled = true;
            BindingExclui.Enabled = true;

            //altera a imagem da picture
            this.PictureBox1.Image = global::BomDia.Properties.Resources.LIGHTON;
            PictureBox1.Visible = true; //figura indica modo operacional do aplicativo
            
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
                TarefasBindingSource.Filter = String.Format("QUANDO = '{0:dd/MM/yyyy}'",
                    ListaDeDatas.Text);
            }
            //
            if (DataPara > DataHoje)
            {
                DataGridView1.Columns[1].HeaderText = "Programático ".ToUpper() + Triang;
                
            }
            if (DataPara < DataHoje)
            {
                DataGridView1.Columns[1].HeaderText = "Em log ".ToUpper() + Triang;;
            }
            if (DataPara == DataHoje)
            {
                MSGtoolStripStatusLabel.Text =
                    "Arquivo de dados: " + BancoDados;
                DataGridView1.Columns[1].HeaderText = "Em tempo real ".ToUpper() +  Triang;
                //DiaBomDiaLabel.Text = "Presente".ToUpper();
            }

            VariaveisGlobais.ListaDeDatasText = ListaDeDatas.Text;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            dateTimePicker1.ResetText();

            string SemanaComMaiuscula;
            SemanaComMaiuscula = DateTime.Today.ToString("ddd");
            SemanaComMaiuscula = SemanaComMaiuscula[0].ToString().ToUpper() +
                SemanaComMaiuscula[1].ToString() + SemanaComMaiuscula[2].ToString() ;
            SemanaToolStripButton.Text =  string.Concat( ".", SemanaComMaiuscula) ;
        }

        // Tornar os dados de um registro anterior como o registro para nova data
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
            // Comando para redesenhar a janela para forma reduzida.

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
            Program.Bomdia.TopMost = true;
            // Ocultar 
            HideForm();

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
        // Escreve as mudanças dinâmicas de data de execução de tarefas para o interface
        //-----------------------------------------------------------------------------
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            //this.label1.Image = null; // imagem ao registro atual não mais existe
            this.PictureBoxEditar.Image = global::BomDia.Properties.Resources.Edit1;
            this.label1.Text = "Editar item...";
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
            MSGtoolStripStatusLabel.Text = "Item: " + DataGridView1.CurrentRow.Cells[0].Value;
            
            if (DataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                {
                    try
                    {
                        MonthCalendarDiamarcado.SelectionRange = new SelectionRange(
                          lower: DateTime.Today,
                          upper: DateTime.Today);
                        if (DataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                        {
                            label5.Text = '\u2714' + " " +  "agenda do dia".ToUpper();
                            return;
                        }
                        else
                        {
                            DataSemana = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
                            if (DataSemana == DateTime.Today)
                            {
                                label5.Text = "Hoje".ToUpper();
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
                            label5.Text = "⛳ Previsto para hoje".ToUpper();
                            return;
                        }
                        else
                        {

                            switch (DataSemana.DayOfWeek)
                            {
                                case DayOfWeek.Monday:
                                    label5.Text = "⮡ segunda-feira".ToUpper();
                                    break;

                                case DayOfWeek.Tuesday:
                                    label5.Text = "⮡ terça-feira".ToUpper();
                                    break;

                                case DayOfWeek.Wednesday:
                                    label5.Text = "⮡ quarta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Thursday:
                                    label5.Text = "⮡ quinta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Friday:
                                    label5.Text = "⮡ sexta-feira".ToUpper();
                                    break;
                                case DayOfWeek.Saturday:
                                    label5.Text = "⮡ sábado".ToUpper();
                                    break;
                                case DayOfWeek.Sunday:
                                    label5.Text = "⮡ domingo".ToUpper();
                                    break;
                                default:
                                    label5.Text = "Não definida".ToUpper();
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

            // definir a propriedade de um menu suspenso.
            dateTimePicker1.ContextMenuStrip = ChaveadorContextMenuStrip;
        }

        private void TarefasBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            label1.Text = "Escrever item";
            this.PictureBoxEditar.Image = global::BomDia.Properties.Resources.NEW;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {
            this.Text = Application.ProductName.ToString() ;
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
        public void PrintPageHandler(object sender, PrintPageEventArgs e, DataGridView dataGridView)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            bool morePagesToPrint = false;
            int currentY = topMargin;

            // Print the header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                int columnWidth = column.Width;
                e.Graphics.DrawString(column.HeaderText, column.InheritedStyle.Font, Brushes.Black, leftMargin, currentY);
                leftMargin += columnWidth;
            }
            // 2*rowHeight
            currentY += 20;
            
            // Print the rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                leftMargin = e.MarginBounds.Left;
                int rowHeight = row.Height;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    
                    int cellWidth = cell.Size.Width;
                    int cellHeight = cell.Size.Height;
                    e.Graphics.DrawString(cell.EditedFormattedValue.ToString(), 
                        cell.InheritedStyle.Font,  Brushes.Black, leftMargin, currentY);
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

        private void button1_Click(object sender, EventArgs e)
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

                this.PictureBoxEditar.Image = global::BomDia.Properties.Resources.CLIP07;
            }
            catch
            {
            }
        }

        private void ButtonAtivarJanela_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Enabled = true;
            BindingNavigatorNovo.Enabled = true;
            BindingExclui.Enabled = true;
            //BindingNavigatorSalva.Enabled = true;
            ButtonAnexa.Enabled = true;

            //altera a imagem da picture

            PictureBox1.Visible = true; //figura indica modo gerenciamento
            ButtonAtivarJanela.Visible = false;
            ListaDeDatas.Focus();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
            {
                switch (PictureBox1.Tag.ToString())
                {
                    case "Apagado":
                        this.PictureBox1.Image = global::BomDia.Properties.Resources.LIGHTON;
                        PictureBox1.Tag = "Aceso";
                        DataGridView1.BackgroundColor = Color.White;
                        DataGridView1.DefaultCellStyle.BackColor = Color.White;
                        DataGridView1.ForeColor = Color.Black;
                        break;

                    case "Aceso":
                    this.PictureBox1.Image = global::BomDia.Properties.Resources.LIGHTOFF;
                        //DataGridView1.BackgroundColor = Color.FromArgb(50, 10, 100);
                        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(50, 10, 100);
                        DataGridView1.ForeColor = Color.White;
                        PictureBox1.Tag = "Apagado";
                        break;
                }
            }
        }

        private void ButtonMoveLista_Click(object sender, EventArgs e)
        {
            int NCaseTrue = 0;
            try 
            {
                string MsgTexto="";
                for (int i = 0; i < NRow; i++)
                {

                    switch (DataGridView1.Rows[i].Cells[7].Value)
                    {
                        case true:
                            NCaseTrue++;
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

                            
                            MsgTexto = 
                                DataGridView1.Rows[i].Cells[0].Value.ToString();
                            MSGtoolStripStatusLabel.Text =
                                "Ok.";

                            break;
                        case false:
                            ;
                            break;
                    }
                    //
                }
                string message = "";
                if (NCaseTrue == 1)
                {
                    message = "Migrado item IND("  + MsgTexto + ") para hoje.";
                }
                else 
                {
                    message = "Migrados " + NCaseTrue + " itens para hoje." +
                        "  Último foi IND(" + MsgTexto + ")";
                }

                    const string caption = "Resgate de Tarefas";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            catch{ };
        }

        private void ShowLineJoin(PaintEventArgs e)
        {
            // Create pen.
            Pen bluePen = new Pen(Color.Black, 1);
            bluePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            // Create points that define line - linha superior do cabeçalho.
            PointF point1 = new PointF(label4.Left+label4.Width, label1.Bottom);
            PointF point2 =
            new PointF(point1.X + flowLayoutPanel1.Width, point1.Y);

            // Draw line to screen.
            e.Graphics.DrawLine(bluePen, point1, point2);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ShowLineJoin(e);
        }
        private void ShowLineJoin_tableLayoutPanel7(PaintEventArgs e)
        {
            // Create pen.
            Pen bluePen = new Pen(Color.Black, 3);
            bluePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            // Create points that define line.
            PointF point1 = new PointF(tableLayoutPanel7.Left, tableLayoutPanel7.Bottom - 2);
            PointF point2 =
            new PointF(point1.X + tableLayoutPanel7.Width, point1.Y);

            // Draw line to screen.
            e.Graphics.DrawLine(bluePen, point1, point2);
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            ShowLineJoin_tableLayoutPanel7(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = Convert.ToDateTime(ListaDeDatas.Text);
                datetime = datetime.AddDays(1);
                ListaDeDatas.Text = datetime.ToShortDateString();
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = Convert.ToDateTime(ListaDeDatas.Text);
                datetime = datetime.AddDays(-1);
                ListaDeDatas.Text = datetime.ToShortDateString();
            }
            catch
            {
                ;
            }
        }


        // Transportar o registro correspondente para o presente.
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(DataGridView1.Rows[i].Cells[7].Value) == false)
                {
                    DataGridView1.Rows[i].Cells[7].Value = true;

                }
                // Migrar a linha atual
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

                string MsgTexto =
                    DataGridView1.Rows[i].Cells[0].Value.ToString();

                MsgTexto = "Migrado IND(" + MsgTexto + ") para o presente.";
                MSGtoolStripStatusLabel.Text = "Ok. " + MsgTexto;
                // Desmarcar linha
                DataGridView1.Rows[i].Cells[7].Value = false;
            }
        }
        private void HideForm()
        {
            if (pad == null)
            {
                return;
            }
            else
            {

                pad.Activate();
                pad.Dispose();
                
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Aplicar um filtro de data
            //
            DataView dataView = new DataView(BomDiaTarefas)
            {
                RowFilter = "DIAMARCADO = '" + maskedTextBoxDia.Value.ToShortDateString() +
        "' and QUANDO = '" + ListaDeDatas.Text + "'"
            };
            DataGridView1.DataSource = dataView;
            MSGtoolStripStatusLabel.Text = "Aplicado um filtro de data";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataGridView1.DataSource = TarefasBindingSource;
        }

        private void ListaDeDatas_Enter(object sender, EventArgs e)
        {
            MSGtoolStripStatusLabel.Text = "Campo: Portal";
        }

        private void AbrirPad()
        {

            if (Program.Bomdia.TopMost == true)
            {
                Program.Bomdia.TopMost = false;
            }

            if (pad == null)
            {
                Program.Bomdia.TopMost = false; pad = new Pad();
                pad.TopLevel = true;
                pad.Portal +=
                    (s, Stexto) => ListaDeDatas.Text = Stexto; // Assina o evento
                return;
            }

        }

        private void DataGridView1_MouseEnter(object sender, EventArgs e)
        {
            if(Program.CharValue == (char)27) 
            {
                Program.CharValue = (char)0;
                SendKeys.Send("{ESC}"); return ; 
            }
            
            if (pad == null) 
            {

                pad = new Pad(); ;
                pad.Show();
            }
            else if (pad.IsDisposed)
            {
                pad = new Pad();
                pad.Show();
            }

            Program.Bomdia.TopMost = false;
            
            pad.TopMost = true;
            pad.TopLevel = true;
            Program.Bomdia.Activate();

            MSGtoolStripStatusLabel.Text = "Pad ativo.";

        }

        private void BomDia_Activated(object sender, EventArgs e)
        {
            // Desativar o formulário secundário.


            Program.Bomdia.MSGtoolStripStatusLabel.Text = "Bom Dia.";
           
        }

        private void DataGridView1_MouseLeave(object sender, EventArgs e)
        {
            // Variável global
            Program.CharValue = (char)0;
        }

        private void memorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Finaliza edição de um registro 
            // conclui a transação para uma tabela temporária
            if(DataGridView1.RowCount == 0) { return; }
            TarefasBindingSource.EndEdit();
            TarefasDataSet.AcceptChanges();

            // Escreve um texto de status 
            MSGtoolStripStatusLabel.Text = "Memorizado ok";
        }
        private void portalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ativa o painel esquerdo de um contêiner
            splitContainer2.Panel1Collapsed = false;
        }
    }

}
