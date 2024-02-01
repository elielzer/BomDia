
namespace BomDia
{
    partial class BomDia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BomDia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TarefasDataSet = new System.Data.DataSet();
            this.BomDiaTarefas = new System.Data.DataTable();
            this.IND = new System.Data.DataColumn();
            this.QUANDO = new System.Data.DataColumn();
            this.OQUE = new System.Data.DataColumn();
            this.PORQUE = new System.Data.DataColumn();
            this.PESO = new System.Data.DataColumn();
            this.CRITÉRIO = new System.Data.DataColumn();
            this.DIAMARCADO = new System.Data.DataColumn();
            this.PrioridadesDataTable = new System.Data.DataTable();
            this.ItemPrioridadeDataColumn = new System.Data.DataColumn();
            this.DenominationDataColumn = new System.Data.DataColumn();
            this.TarefasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.iNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pORQUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrioridadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRITÉRIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChaveadorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cortinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BindingNavigatorNovo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingExclui = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSalva = new System.Windows.Forms.BindingNavigator(this.components);
            this.SalvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMigrar = new System.Windows.Forms.BindingNavigator(this.components);
            this.MigrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OQuePretendido = new System.Windows.Forms.RichTextBox();
            this.DetalhePorQue = new System.Windows.Forms.TextBox();
            this.DetalheQuando = new System.Windows.Forms.TextBox();
            this.INDPretendido = new System.Windows.Forms.TextBox();
            this.BindingNavegador = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ContextMenuStripVoltar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaDeDatas = new System.Windows.Forms.ListBox();
            this.ContextMenuStripHoje = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaMarcadoPretendido = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.MonthCalendarDiamarcado = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxIntegrador = new System.Windows.Forms.CheckBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.AbrirToolStripButtonGerenciar = new System.Windows.Forms.ToolStripButton();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BindingNavigatorSemana = new System.Windows.Forms.BindingNavigator(this.components);
            this.SemanaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusStripBomDia = new System.Windows.Forms.StatusStrip();
            this.MSGtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataHoje = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemPrioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.DiaBomDiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BomDiaTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarefasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadesBindingSource)).BeginInit();
            this.ChaveadorContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorNovo)).BeginInit();
            this.BindingNavigatorNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingExclui)).BeginInit();
            this.BindingExclui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorSalva)).BeginInit();
            this.BindingNavigatorSalva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorMigrar)).BeginInit();
            this.BindingNavigatorMigrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavegador)).BeginInit();
            this.BindingNavegador.SuspendLayout();
            this.ContextMenuStripVoltar.SuspendLayout();
            this.ContextMenuStripHoje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorSemana)).BeginInit();
            this.BindingNavigatorSemana.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.StatusStripBomDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TarefasDataSet
            // 
            this.TarefasDataSet.DataSetName = "TarefasDataSet";
            this.TarefasDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.BomDiaTarefas,
            this.PrioridadesDataTable});
            // 
            // BomDiaTarefas
            // 
            this.BomDiaTarefas.Columns.AddRange(new System.Data.DataColumn[] {
            this.IND,
            this.QUANDO,
            this.OQUE,
            this.PORQUE,
            this.PESO,
            this.CRITÉRIO,
            this.DIAMARCADO});
            this.BomDiaTarefas.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "IND"}, false)});
            this.BomDiaTarefas.TableName = "BomDiaTarefas";
            // 
            // IND
            // 
            this.IND.AutoIncrement = true;
            this.IND.ColumnName = "IND";
            this.IND.DataType = typeof(int);
            // 
            // QUANDO
            // 
            this.QUANDO.ColumnName = "QUANDO";
            this.QUANDO.DataType = typeof(System.DateTime);
            // 
            // OQUE
            // 
            this.OQUE.Caption = "OQUE";
            this.OQUE.ColumnName = "OQUE";
            // 
            // PORQUE
            // 
            this.PORQUE.ColumnName = "PORQUE";
            // 
            // PESO
            // 
            this.PESO.ColumnName = "PESO";
            this.PESO.DataType = typeof(float);
            // 
            // CRITÉRIO
            // 
            this.CRITÉRIO.Caption = "CRITÉRIO";
            this.CRITÉRIO.ColumnName = "CRITÉRIO";
            // 
            // DIAMARCADO
            // 
            this.DIAMARCADO.Caption = "Dia Marcado";
            this.DIAMARCADO.ColumnName = "DIAMARCADO";
            this.DIAMARCADO.DataType = typeof(System.DateTime);
            // 
            // PrioridadesDataTable
            // 
            this.PrioridadesDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.ItemPrioridadeDataColumn,
            this.DenominationDataColumn});
            this.PrioridadesDataTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ItemPrioridade"}, false)});
            this.PrioridadesDataTable.TableName = "Prioridades";
            // 
            // ItemPrioridadeDataColumn
            // 
            this.ItemPrioridadeDataColumn.AllowDBNull = false;
            this.ItemPrioridadeDataColumn.ColumnName = "ItemPrioridade";
            this.ItemPrioridadeDataColumn.MaxLength = 1;
            // 
            // DenominationDataColumn
            // 
            this.DenominationDataColumn.ColumnName = "Denomination";
            this.DenominationDataColumn.MaxLength = 200;
            // 
            // TarefasBindingSource
            // 
            this.TarefasBindingSource.DataMember = "BomDiaTarefas";
            this.TarefasBindingSource.DataSource = this.TarefasDataSet;
            this.TarefasBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.TarefasBindingSource_AddingNew);
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNDDataGridViewTextBoxColumn,
            this.qUANDODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.oQUEDataGridViewTextBoxColumn,
            this.pORQUEDataGridViewTextBoxColumn,
            this.pESODataGridViewTextBoxColumn,
            this.cRITÉRIODataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.TarefasBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(3, 16);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 25;
            this.DataGridView1.RowTemplate.Height = 30;
            this.DataGridView1.Size = new System.Drawing.Size(717, 289);
            this.DataGridView1.TabIndex = 8;
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.DataGridView1.Enter += new System.EventHandler(this.DataGridView1_Enter);
            // 
            // iNDDataGridViewTextBoxColumn
            // 
            this.iNDDataGridViewTextBoxColumn.DataPropertyName = "IND";
            this.iNDDataGridViewTextBoxColumn.HeaderText = "IND";
            this.iNDDataGridViewTextBoxColumn.Name = "iNDDataGridViewTextBoxColumn";
            this.iNDDataGridViewTextBoxColumn.Width = 50;
            // 
            // qUANDODataGridViewTextBoxColumn
            // 
            this.qUANDODataGridViewTextBoxColumn.DataPropertyName = "QUANDO";
            this.qUANDODataGridViewTextBoxColumn.HeaderText = "QUANDO";
            this.qUANDODataGridViewTextBoxColumn.Name = "qUANDODataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DIAMARCADO";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn1.HeaderText = "DATA LIMITE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // oQUEDataGridViewTextBoxColumn
            // 
            this.oQUEDataGridViewTextBoxColumn.DataPropertyName = "OQUE";
            this.oQUEDataGridViewTextBoxColumn.HeaderText = "O QUÊ";
            this.oQUEDataGridViewTextBoxColumn.Name = "oQUEDataGridViewTextBoxColumn";
            this.oQUEDataGridViewTextBoxColumn.Width = 300;
            // 
            // pORQUEDataGridViewTextBoxColumn
            // 
            this.pORQUEDataGridViewTextBoxColumn.DataPropertyName = "PORQUE";
            this.pORQUEDataGridViewTextBoxColumn.DataSource = this.PrioridadesBindingSource;
            this.pORQUEDataGridViewTextBoxColumn.DisplayMember = "Denomination";
            this.pORQUEDataGridViewTextBoxColumn.HeaderText = "POR QUÊ";
            this.pORQUEDataGridViewTextBoxColumn.Name = "pORQUEDataGridViewTextBoxColumn";
            this.pORQUEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pORQUEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pORQUEDataGridViewTextBoxColumn.ValueMember = "ItemPrioridade";
            this.pORQUEDataGridViewTextBoxColumn.Width = 200;
            // 
            // PrioridadesBindingSource
            // 
            this.PrioridadesBindingSource.DataMember = "Prioridades";
            this.PrioridadesBindingSource.DataSource = this.TarefasDataSet;
            // 
            // pESODataGridViewTextBoxColumn
            // 
            this.pESODataGridViewTextBoxColumn.DataPropertyName = "PESO";
            this.pESODataGridViewTextBoxColumn.HeaderText = "PESO";
            this.pESODataGridViewTextBoxColumn.Name = "pESODataGridViewTextBoxColumn";
            this.pESODataGridViewTextBoxColumn.Width = 40;
            // 
            // cRITÉRIODataGridViewTextBoxColumn
            // 
            this.cRITÉRIODataGridViewTextBoxColumn.DataPropertyName = "CRITÉRIO";
            this.cRITÉRIODataGridViewTextBoxColumn.HeaderText = "QUAL CRITÉRIO";
            this.cRITÉRIODataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Maior melhor",
            "Menor melhor"});
            this.cRITÉRIODataGridViewTextBoxColumn.Name = "cRITÉRIODataGridViewTextBoxColumn";
            this.cRITÉRIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRITÉRIODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cRITÉRIODataGridViewTextBoxColumn.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 42);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // ChaveadorContextMenuStrip
            // 
            this.ChaveadorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortinaToolStripMenuItem});
            this.ChaveadorContextMenuStrip.Name = "ChaveadorContextMenuStrip";
            this.ChaveadorContextMenuStrip.Size = new System.Drawing.Size(111, 26);
            // 
            // cortinaToolStripMenuItem
            // 
            this.cortinaToolStripMenuItem.Name = "cortinaToolStripMenuItem";
            this.cortinaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cortinaToolStripMenuItem.Text = "Tarefas";
            this.cortinaToolStripMenuItem.Click += new System.EventHandler(this.CortinaToolStripMenuItem_Click);
            // 
            // BindingNavigatorNovo
            // 
            this.BindingNavigatorNovo.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigatorNovo.BindingSource = this.TarefasBindingSource;
            this.BindingNavigatorNovo.CountItem = null;
            this.BindingNavigatorNovo.DeleteItem = null;
            this.BindingNavigatorNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigatorNovo.Enabled = false;
            this.BindingNavigatorNovo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem});
            this.BindingNavigatorNovo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BindingNavigatorNovo.Location = new System.Drawing.Point(605, 74);
            this.BindingNavigatorNovo.MoveFirstItem = null;
            this.BindingNavigatorNovo.MoveLastItem = null;
            this.BindingNavigatorNovo.MoveNextItem = null;
            this.BindingNavigatorNovo.MovePreviousItem = null;
            this.BindingNavigatorNovo.Name = "BindingNavigatorNovo";
            this.BindingNavigatorNovo.PositionItem = null;
            this.BindingNavigatorNovo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BindingNavigatorNovo.Size = new System.Drawing.Size(101, 27);
            this.BindingNavigatorNovo.TabIndex = 3;
            this.BindingNavigatorNovo.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigatorAddNewItem.Image = global::BomDia.Properties.Resources.AzureIoTHubEdit_16x;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(99, 24);
            this.bindingNavigatorAddNewItem.Text = "&Novo Item";
            this.bindingNavigatorAddNewItem.ToolTipText = "Nova tarefa";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // BindingExclui
            // 
            this.BindingExclui.AddNewItem = null;
            this.BindingExclui.BindingSource = this.TarefasBindingSource;
            this.BindingExclui.CountItem = null;
            this.BindingExclui.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingExclui.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingExclui.Enabled = false;
            this.BindingExclui.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem});
            this.BindingExclui.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BindingExclui.Location = new System.Drawing.Point(26, 62);
            this.BindingExclui.MoveFirstItem = null;
            this.BindingExclui.MoveLastItem = null;
            this.BindingExclui.MoveNextItem = null;
            this.BindingExclui.MovePreviousItem = null;
            this.BindingExclui.Name = "BindingExclui";
            this.BindingExclui.PositionItem = null;
            this.BindingExclui.Size = new System.Drawing.Size(24, 23);
            this.BindingExclui.TabIndex = 6;
            this.BindingExclui.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // BindingNavigatorSalva
            // 
            this.BindingNavigatorSalva.AddNewItem = null;
            this.BindingNavigatorSalva.AutoSize = false;
            this.BindingNavigatorSalva.CountItem = null;
            this.BindingNavigatorSalva.DeleteItem = null;
            this.BindingNavigatorSalva.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorSalva.Enabled = false;
            this.BindingNavigatorSalva.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigatorSalva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalvarToolStripButton});
            this.BindingNavigatorSalva.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.BindingNavigatorSalva.Location = new System.Drawing.Point(3, 3);
            this.BindingNavigatorSalva.MoveFirstItem = null;
            this.BindingNavigatorSalva.MoveLastItem = null;
            this.BindingNavigatorSalva.MoveNextItem = null;
            this.BindingNavigatorSalva.MovePreviousItem = null;
            this.BindingNavigatorSalva.Name = "BindingNavigatorSalva";
            this.BindingNavigatorSalva.PositionItem = null;
            this.BindingNavigatorSalva.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BindingNavigatorSalva.Size = new System.Drawing.Size(76, 38);
            this.BindingNavigatorSalva.TabIndex = 5;
            this.BindingNavigatorSalva.TabStop = true;
            this.BindingNavigatorSalva.Text = "bindingNavigator1";
            // 
            // SalvarToolStripButton
            // 
            this.SalvarToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SalvarToolStripButton.AutoSize = false;
            this.SalvarToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SalvarToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarToolStripButton.ForeColor = System.Drawing.Color.Blue;
            this.SalvarToolStripButton.Image = global::BomDia.Properties.Resources.CLIP07;
            this.SalvarToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalvarToolStripButton.Name = "SalvarToolStripButton";
            this.SalvarToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.SalvarToolStripButton.Text = "Ane&xar";
            this.SalvarToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.SalvarToolStripButton.Click += new System.EventHandler(this.SalvarToolStripButton_Click);
            // 
            // BindingNavigatorMigrar
            // 
            this.BindingNavigatorMigrar.AddNewItem = null;
            this.BindingNavigatorMigrar.AutoSize = false;
            this.BindingNavigatorMigrar.CountItem = null;
            this.BindingNavigatorMigrar.DeleteItem = null;
            this.BindingNavigatorMigrar.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorMigrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MigrarToolStripButton});
            this.BindingNavigatorMigrar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BindingNavigatorMigrar.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigatorMigrar.MoveFirstItem = null;
            this.BindingNavigatorMigrar.MoveLastItem = null;
            this.BindingNavigatorMigrar.MoveNextItem = null;
            this.BindingNavigatorMigrar.MovePreviousItem = null;
            this.BindingNavigatorMigrar.Name = "BindingNavigatorMigrar";
            this.BindingNavigatorMigrar.PositionItem = null;
            this.BindingNavigatorMigrar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BindingNavigatorMigrar.ShowItemToolTips = false;
            this.BindingNavigatorMigrar.Size = new System.Drawing.Size(101, 25);
            this.BindingNavigatorMigrar.Stretch = true;
            this.BindingNavigatorMigrar.TabIndex = 9;
            this.BindingNavigatorMigrar.Text = "bindingNavigatorMigrar";
            // 
            // MigrarToolStripButton
            // 
            this.MigrarToolStripButton.AutoSize = false;
            this.MigrarToolStripButton.AutoToolTip = false;
            this.MigrarToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MigrarToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MigrarToolStripButton.ForeColor = System.Drawing.Color.Snow;
            this.MigrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("MigrarToolStripButton.Image")));
            this.MigrarToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MigrarToolStripButton.Name = "MigrarToolStripButton";
            this.MigrarToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MigrarToolStripButton.Size = new System.Drawing.Size(100, 25);
            this.MigrarToolStripButton.Text = "&Migrar tarefa";
            this.MigrarToolStripButton.Click += new System.EventHandler(this.MigrarToolStripButton_Click);
            // 
            // OQuePretendido
            // 
            this.OQuePretendido.BackColor = System.Drawing.Color.White;
            this.OQuePretendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OQuePretendido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "OQUE", true));
            this.OQuePretendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OQuePretendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OQuePretendido.Location = new System.Drawing.Point(3, 25);
            this.OQuePretendido.Name = "OQuePretendido";
            this.OQuePretendido.Size = new System.Drawing.Size(420, 73);
            this.OQuePretendido.TabIndex = 4;
            this.OQuePretendido.Text = "";
            // 
            // DetalhePorQue
            // 
            this.DetalhePorQue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "PORQUE", true));
            this.DetalhePorQue.Location = new System.Drawing.Point(355, 5);
            this.DetalhePorQue.Name = "DetalhePorQue";
            this.DetalhePorQue.Size = new System.Drawing.Size(100, 20);
            this.DetalhePorQue.TabIndex = 7;
            this.DetalhePorQue.Visible = false;
            // 
            // DetalheQuando
            // 
            this.DetalheQuando.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "QUANDO", true));
            this.DetalheQuando.Location = new System.Drawing.Point(232, 5);
            this.DetalheQuando.Name = "DetalheQuando";
            this.DetalheQuando.Size = new System.Drawing.Size(100, 20);
            this.DetalheQuando.TabIndex = 6;
            this.DetalheQuando.Visible = false;
            // 
            // INDPretendido
            // 
            this.INDPretendido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "IND", true));
            this.INDPretendido.Location = new System.Drawing.Point(76, 8);
            this.INDPretendido.Name = "INDPretendido";
            this.INDPretendido.Size = new System.Drawing.Size(100, 20);
            this.INDPretendido.TabIndex = 4;
            this.INDPretendido.Visible = false;
            // 
            // BindingNavegador
            // 
            this.BindingNavegador.AddNewItem = null;
            this.BindingNavegador.AllowItemReorder = true;
            this.BindingNavegador.AutoSize = false;
            this.BindingNavegador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BindingNavegador.BindingSource = this.TarefasBindingSource;
            this.BindingNavegador.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavegador.CountItemFormat = "/ {0}";
            this.BindingNavegador.DeleteItem = null;
            this.BindingNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingNavegador.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavegador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.toolStripLabel1,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.BindingNavegador.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BindingNavegador.Location = new System.Drawing.Point(138, 0);
            this.BindingNavegador.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavegador.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavegador.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavegador.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavegador.Name = "BindingNavegador";
            this.BindingNavegador.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavegador.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BindingNavegador.Size = new System.Drawing.Size(585, 25);
            this.BindingNavegador.Stretch = true;
            this.BindingNavegador.TabIndex = 5;
            this.BindingNavegador.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.AutoSize = false;
            this.bindingNavigatorCountItem.Margin = new System.Windows.Forms.Padding(1, -1, 1, 2);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 23);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 15);
            this.toolStripLabel1.Text = "Linhas:";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.ImageTransparentColor = System.Drawing.Color.White;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(83, 19);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // ContextMenuStripVoltar
            // 
            this.ContextMenuStripVoltar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.ContextMenuStripVoltar.Name = "ContextMenuStripVoltar";
            this.ContextMenuStripVoltar.Size = new System.Drawing.Size(105, 26);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.voltarToolStripMenuItem.Text = "&Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.VoltarToolStripMenuItem_Click);
            // 
            // ListaDeDatas
            // 
            this.ListaDeDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListaDeDatas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaDeDatas.ContextMenuStrip = this.ContextMenuStripHoje;
            this.ListaDeDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDeDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDeDatas.FormattingEnabled = true;
            this.ListaDeDatas.ItemHeight = 16;
            this.ListaDeDatas.Items.AddRange(new object[] {
            "03/11/2021",
            "04/11/2021",
            "05/11/2021",
            "06/11/2021",
            "07/11/2021",
            "08/11/2021",
            "09/11/2021",
            "10/11/2021",
            "11/11/2021",
            "12/11/2021",
            "13/11/2021",
            "14/11/2021",
            "15/11/2021",
            "16/11/2021",
            "17/11/2021",
            "18/11/2021",
            "19/11/2021",
            "20/11/2021",
            "21/11/2021",
            "22/11/2021",
            "23/11/2021",
            "24/11/2021",
            "25/11/2021",
            "26/11/2021",
            "27/11/2021",
            "28/11/2021",
            "29/11/2021",
            "30/11/2021",
            "01/12/2021",
            "02/12/2021",
            "03/12/2021",
            "04/12/2021",
            "05/12/2021",
            "06/12/2021",
            "07/12/2021",
            "08/12/2021",
            "09/12/2021",
            "10/12/2021",
            "11/12/2021",
            "12/12/2021",
            "13/12/2021",
            "14/12/2021",
            "15/12/2021",
            "16/12/2021",
            "17/12/2021",
            "18/12/2021",
            "19/12/2021",
            "20/12/2021",
            "21/12/2021",
            "22/12/2021",
            "23/12/2021",
            "24/12/2021",
            "25/12/2021",
            "26/12/2021",
            "27/12/2021",
            "28/12/2021",
            "29/12/2021",
            "30/12/2021",
            "31/12/2021",
            "01/01/2022",
            "02/01/2022",
            "03/01/2022",
            "04/01/2022",
            "05/01/2022",
            "06/01/2022",
            "07/01/2022",
            "08/01/2022",
            "09/01/2022",
            "10/01/2022",
            "11/01/2022",
            "12/01/2022",
            "13/01/2022",
            "14/01/2022",
            "15/01/2022",
            "16/01/2022",
            "17/01/2022",
            "18/01/2022",
            "19/01/2022",
            "20/01/2022",
            "21/01/2022",
            "22/01/2022",
            "23/01/2022",
            "24/01/2022",
            "25/01/2022",
            "26/01/2022",
            "27/01/2022",
            "28/01/2022",
            "29/01/2022",
            "30/01/2022",
            "31/01/2022",
            "01/02/2022",
            "02/02/2022",
            "03/02/2022",
            "04/02/2022",
            "05/02/2022",
            "06/02/2022",
            "07/02/2022",
            "08/02/2022",
            "09/02/2022",
            "10/02/2022",
            "11/02/2022",
            "12/02/2022",
            "13/02/2022",
            "14/02/2022",
            "15/02/2022",
            "16/02/2022",
            "17/02/2022",
            "18/02/2022",
            "19/02/2022",
            "20/02/2022",
            "21/02/2022",
            "22/02/2022",
            "23/02/2022",
            "24/02/2022",
            "25/02/2022",
            "26/02/2022",
            "27/02/2022",
            "28/02/2022",
            "01/03/2022",
            "02/03/2022",
            "03/03/2022",
            "04/03/2022",
            "05/03/2022",
            "06/03/2022",
            "07/03/2022",
            "08/03/2022",
            "09/03/2022",
            "10/03/2022",
            "11/03/2022",
            "12/03/2022",
            "13/03/2022",
            "14/03/2022",
            "15/03/2022",
            "16/03/2022",
            "17/03/2022",
            "18/03/2022",
            "19/03/2022",
            "20/03/2022",
            "21/03/2022",
            "22/03/2022",
            "23/03/2022",
            "24/03/2022",
            "25/03/2022",
            "26/03/2022",
            "27/03/2022",
            "28/03/2022",
            "29/03/2022",
            "30/03/2022",
            "31/03/2022",
            "01/04/2022",
            "02/04/2022",
            "03/04/2022",
            "04/04/2022",
            "05/04/2022",
            "06/04/2022",
            "07/04/2022",
            "08/04/2022",
            "09/04/2022",
            "10/04/2022",
            "11/04/2022",
            "12/04/2022",
            "13/04/2022",
            "14/04/2022",
            "15/04/2022",
            "16/04/2022",
            "17/04/2022",
            "18/04/2022",
            "19/04/2022",
            "20/04/2022",
            "21/04/2022",
            "22/04/2022",
            "23/04/2022",
            "24/04/2022",
            "25/04/2022",
            "26/04/2022",
            "27/04/2022",
            "28/04/2022",
            "29/04/2022",
            "30/04/2022",
            "01/05/2022",
            "02/05/2022",
            "03/05/2022",
            "04/05/2022",
            "05/05/2022",
            "06/05/2022",
            "07/05/2022",
            "08/05/2022",
            "09/05/2022",
            "10/05/2022",
            "11/05/2022",
            "12/05/2022",
            "13/05/2022",
            "14/05/2022",
            "15/05/2022",
            "16/05/2022",
            "17/05/2022",
            "18/05/2022",
            "19/05/2022",
            "20/05/2022",
            "21/05/2022",
            "22/05/2022",
            "23/05/2022",
            "24/05/2022",
            "25/05/2022",
            "26/05/2022",
            "27/05/2022",
            "28/05/2022",
            "29/05/2022",
            "30/05/2022",
            "31/05/2022",
            "01/06/2022",
            "02/06/2022",
            "03/06/2022",
            "04/06/2022",
            "05/06/2022",
            "06/06/2022",
            "07/06/2022",
            "08/06/2022",
            "09/06/2022",
            "10/06/2022",
            "11/06/2022",
            "12/06/2022",
            "13/06/2022",
            "14/06/2022",
            "15/06/2022",
            "16/06/2022",
            "17/06/2022",
            "18/06/2022",
            "19/06/2022",
            "20/06/2022",
            "21/06/2022",
            "22/06/2022",
            "23/06/2022",
            "24/06/2022",
            "25/06/2022",
            "26/06/2022",
            "27/06/2022",
            "28/06/2022",
            "29/06/2022",
            "30/06/2022",
            "01/07/2022",
            "02/07/2022",
            "03/07/2022",
            "04/07/2022",
            "05/07/2022",
            "06/07/2022",
            "07/07/2022",
            "08/07/2022",
            "09/07/2022",
            "10/07/2022",
            "11/07/2022",
            "12/07/2022",
            "13/07/2022",
            "14/07/2022",
            "15/07/2022",
            "16/07/2022",
            "17/07/2022",
            "18/07/2022",
            "19/07/2022",
            "20/07/2022",
            "21/07/2022",
            "22/07/2022",
            "23/07/2022",
            "24/07/2022",
            "25/07/2022",
            "26/07/2022",
            "27/07/2022",
            "28/07/2022",
            "29/07/2022",
            "30/07/2022",
            "31/07/2022",
            "01/08/2022",
            "02/08/2022",
            "03/08/2022",
            "04/08/2022",
            "05/08/2022",
            "06/08/2022",
            "07/08/2022",
            "08/08/2022",
            "09/08/2022",
            "10/08/2022",
            "11/08/2022",
            "12/08/2022",
            "13/08/2022",
            "14/08/2022",
            "15/08/2022",
            "16/08/2022",
            "17/08/2022",
            "18/08/2022",
            "19/08/2022",
            "20/08/2022",
            "21/08/2022",
            "22/08/2022",
            "23/08/2022",
            "24/08/2022",
            "25/08/2022",
            "26/08/2022",
            "27/08/2022",
            "28/08/2022",
            "29/08/2022",
            "30/08/2022",
            "31/08/2022",
            "01/09/2022",
            "02/09/2022",
            "03/09/2022",
            "04/09/2022",
            "05/09/2022",
            "06/09/2022",
            "07/09/2022",
            "08/09/2022",
            "09/09/2022",
            "10/09/2022",
            "11/09/2022",
            "12/09/2022",
            "13/09/2022",
            "14/09/2022",
            "15/09/2022",
            "16/09/2022",
            "17/09/2022",
            "18/09/2022",
            "19/09/2022",
            "20/09/2022",
            "21/09/2022",
            "22/09/2022",
            "23/09/2022",
            "24/09/2022",
            "25/09/2022",
            "26/09/2022",
            "27/09/2022",
            "28/09/2022",
            "29/09/2022",
            "30/09/2022",
            "01/10/2022",
            "02/10/2022",
            "03/10/2022",
            "04/10/2022",
            "05/10/2022",
            "06/10/2022",
            "07/10/2022",
            "08/10/2022",
            "09/10/2022",
            "10/10/2022",
            "11/10/2022",
            "12/10/2022",
            "13/10/2022",
            "14/10/2022",
            "15/10/2022",
            "16/10/2022",
            "17/10/2022",
            "18/10/2022",
            "19/10/2022",
            "20/10/2022",
            "21/10/2022",
            "22/10/2022",
            "23/10/2022",
            "24/10/2022",
            "25/10/2022",
            "26/10/2022",
            "27/10/2022",
            "28/10/2022",
            "29/10/2022",
            "30/10/2022",
            "31/10/2022",
            "01/11/2022",
            "02/11/2022",
            "03/11/2022",
            "04/11/2022",
            "05/11/2022",
            "06/11/2022",
            "07/11/2022",
            "08/11/2022",
            "09/11/2022",
            "10/11/2022",
            "11/11/2022",
            "12/11/2022",
            "13/11/2022",
            "14/11/2022",
            "15/11/2022",
            "16/11/2022",
            "17/11/2022",
            "18/11/2022",
            "19/11/2022",
            "20/11/2022",
            "21/11/2022",
            "22/11/2022",
            "23/11/2022",
            "24/11/2022",
            "25/11/2022",
            "26/11/2022",
            "27/11/2022",
            "28/11/2022",
            "29/11/2022",
            "30/11/2022",
            "01/12/2022",
            "02/12/2022",
            "03/12/2022",
            "04/12/2022",
            "05/12/2022",
            "06/12/2022",
            "07/12/2022",
            "08/12/2022",
            "09/12/2022",
            "10/12/2022",
            "11/12/2022",
            "12/12/2022",
            "13/12/2022",
            "14/12/2022",
            "15/12/2022",
            "16/12/2022",
            "17/12/2022",
            "18/12/2022",
            "19/12/2022",
            "20/12/2022",
            "21/12/2022",
            "22/12/2022",
            "23/12/2022",
            "24/12/2022",
            "25/12/2022",
            "26/12/2022",
            "27/12/2022",
            "28/12/2022",
            "29/12/2022",
            "30/12/2022",
            "31/12/2022",
            "01/01/2023",
            "02/01/2023",
            "03/01/2023",
            "04/01/2023",
            "05/01/2023",
            "06/01/2023",
            "07/01/2023",
            "08/01/2023",
            "09/01/2023",
            "10/01/2023",
            "11/01/2023",
            "12/01/2023",
            "13/01/2023",
            "14/01/2023",
            "15/01/2023",
            "16/01/2023",
            "17/01/2023",
            "18/01/2023",
            "19/01/2023",
            "20/01/2023",
            "21/01/2023",
            "22/01/2023",
            "23/01/2023",
            "24/01/2023",
            "25/01/2023",
            "26/01/2023",
            "27/01/2023",
            "28/01/2023",
            "29/01/2023",
            "30/01/2023",
            "31/01/2023",
            "01/02/2023",
            "02/02/2023",
            "03/02/2023",
            "04/02/2023",
            "05/02/2023",
            "06/02/2023",
            "07/02/2023",
            "08/02/2023",
            "09/02/2023",
            "10/02/2023",
            "11/02/2023",
            "12/02/2023",
            "13/02/2023",
            "14/02/2023",
            "15/02/2023",
            "16/02/2023",
            "17/02/2023",
            "18/02/2023",
            "19/02/2023",
            "20/02/2023",
            "21/02/2023",
            "22/02/2023",
            "23/02/2023",
            "24/02/2023",
            "25/02/2023",
            "26/02/2023",
            "27/02/2023",
            "28/02/2023",
            "01/03/2023",
            "02/03/2023",
            "03/03/2023",
            "04/03/2023",
            "05/03/2023",
            "06/03/2023",
            "07/03/2023",
            "08/03/2023",
            "09/03/2023",
            "10/03/2023",
            "11/03/2023",
            "12/03/2023",
            "13/03/2023",
            "14/03/2023",
            "15/03/2023",
            "16/03/2023",
            "17/03/2023",
            "18/03/2023",
            "19/03/2023",
            "20/03/2023",
            "21/03/2023",
            "22/03/2023",
            "23/03/2023",
            "24/03/2023",
            "25/03/2023",
            "26/03/2023",
            "27/03/2023",
            "28/03/2023",
            "29/03/2023",
            "30/03/2023",
            "31/03/2023",
            "01/04/2023",
            "02/04/2023",
            "03/04/2023",
            "04/04/2023",
            "05/04/2023",
            "06/04/2023",
            "07/04/2023",
            "08/04/2023",
            "09/04/2023",
            "10/04/2023",
            "11/04/2023",
            "12/04/2023",
            "13/04/2023",
            "14/04/2023",
            "15/04/2023",
            "16/04/2023",
            "17/04/2023",
            "18/04/2023",
            "19/04/2023",
            "20/04/2023",
            "21/04/2023",
            "22/04/2023",
            "23/04/2023",
            "24/04/2023",
            "25/04/2023",
            "26/04/2023",
            "27/04/2023",
            "28/04/2023",
            "29/04/2023",
            "30/04/2023",
            "01/05/2023",
            "02/05/2023",
            "03/05/2023",
            "04/05/2023",
            "05/05/2023",
            "06/05/2023",
            "07/05/2023",
            "08/05/2023",
            "09/05/2023",
            "10/05/2023",
            "11/05/2023",
            "12/05/2023",
            "13/05/2023",
            "14/05/2023",
            "15/05/2023",
            "16/05/2023",
            "17/05/2023",
            "18/05/2023",
            "19/05/2023",
            "20/05/2023",
            "21/05/2023",
            "22/05/2023",
            "23/05/2023",
            "24/05/2023",
            "25/05/2023",
            "26/05/2023",
            "27/05/2023",
            "28/05/2023",
            "29/05/2023",
            "30/05/2023",
            "31/05/2023",
            "01/06/2023",
            "02/06/2023",
            "03/06/2023",
            "04/06/2023",
            "05/06/2023",
            "06/06/2023",
            "07/06/2023",
            "08/06/2023",
            "09/06/2023",
            "10/06/2023",
            "11/06/2023",
            "12/06/2023",
            "13/06/2023",
            "14/06/2023",
            "15/06/2023",
            "16/06/2023",
            "17/06/2023",
            "18/06/2023",
            "19/06/2023",
            "20/06/2023",
            "21/06/2023",
            "22/06/2023",
            "23/06/2023",
            "24/06/2023",
            "25/06/2023",
            "26/06/2023",
            "27/06/2023",
            "28/06/2023",
            "29/06/2023",
            "30/06/2023",
            "01/07/2023",
            "02/07/2023",
            "03/07/2023",
            "04/07/2023",
            "05/07/2023",
            "06/07/2023",
            "07/07/2023",
            "08/07/2023",
            "09/07/2023",
            "10/07/2023",
            "11/07/2023",
            "12/07/2023",
            "13/07/2023",
            "14/07/2023",
            "15/07/2023",
            "16/07/2023",
            "17/07/2023",
            "18/07/2023",
            "19/07/2023",
            "20/07/2023",
            "21/07/2023",
            "22/07/2023",
            "23/07/2023",
            "24/07/2023",
            "25/07/2023",
            "26/07/2023",
            "27/07/2023",
            "28/07/2023",
            "29/07/2023",
            "30/07/2023",
            "31/07/2023",
            "01/08/2023",
            "02/08/2023",
            "03/08/2023",
            "04/08/2023",
            "05/08/2023",
            "06/08/2023",
            "07/08/2023",
            "08/08/2023",
            "09/08/2023",
            "10/08/2023",
            "11/08/2023",
            "12/08/2023",
            "13/08/2023",
            "14/08/2023",
            "15/08/2023",
            "16/08/2023",
            "17/08/2023",
            "18/08/2023",
            "19/08/2023",
            "20/08/2023",
            "21/08/2023",
            "22/08/2023",
            "23/08/2023",
            "24/08/2023",
            "25/08/2023",
            "26/08/2023",
            "27/08/2023",
            "28/08/2023",
            "29/08/2023",
            "30/08/2023",
            "31/08/2023",
            "01/09/2023",
            "02/09/2023",
            "03/09/2023",
            "04/09/2023",
            "05/09/2023",
            "06/09/2023",
            "07/09/2023",
            "08/09/2023",
            "09/09/2023",
            "10/09/2023",
            "11/09/2023",
            "12/09/2023",
            "13/09/2023",
            "14/09/2023",
            "15/09/2023",
            "16/09/2023",
            "17/09/2023",
            "18/09/2023",
            "19/09/2023",
            "20/09/2023",
            "21/09/2023",
            "22/09/2023",
            "23/09/2023",
            "24/09/2023",
            "25/09/2023",
            "26/09/2023",
            "27/09/2023",
            "28/09/2023",
            "29/09/2023",
            "30/09/2023",
            "01/10/2023",
            "02/10/2023",
            "03/10/2023",
            "04/10/2023",
            "05/10/2023",
            "06/10/2023",
            "07/10/2023",
            "08/10/2023",
            "09/10/2023",
            "10/10/2023",
            "11/10/2023",
            "12/10/2023",
            "13/10/2023",
            "14/10/2023",
            "15/10/2023",
            "16/10/2023",
            "17/10/2023",
            "18/10/2023",
            "19/10/2023",
            "20/10/2023",
            "21/10/2023",
            "22/10/2023",
            "23/10/2023",
            "24/10/2023",
            "25/10/2023",
            "26/10/2023",
            "27/10/2023",
            "28/10/2023",
            "29/10/2023",
            "30/10/2023",
            "31/10/2023",
            "01/11/2023",
            "02/11/2023",
            "03/11/2023",
            "04/11/2023",
            "05/11/2023",
            "06/11/2023",
            "07/11/2023",
            "08/11/2023",
            "09/11/2023",
            "10/11/2023",
            "11/11/2023",
            "12/11/2023",
            "13/11/2023",
            "14/11/2023",
            "15/11/2023",
            "16/11/2023",
            "17/11/2023",
            "18/11/2023",
            "19/11/2023",
            "20/11/2023",
            "21/11/2023",
            "22/11/2023",
            "23/11/2023",
            "24/11/2023",
            "25/11/2023",
            "26/11/2023",
            "27/11/2023",
            "28/11/2023",
            "29/11/2023",
            "30/11/2023",
            "01/12/2023",
            "02/12/2023",
            "03/12/2023",
            "04/12/2023",
            "05/12/2023",
            "06/12/2023",
            "07/12/2023",
            "08/12/2023",
            "09/12/2023",
            "10/12/2023",
            "11/12/2023",
            "12/12/2023",
            "13/12/2023",
            "14/12/2023",
            "15/12/2023",
            "16/12/2023",
            "17/12/2023",
            "18/12/2023",
            "19/12/2023",
            "20/12/2023",
            "21/12/2023",
            "22/12/2023",
            "23/12/2023",
            "24/12/2023",
            "25/12/2023",
            "26/12/2023",
            "27/12/2023",
            "28/12/2023",
            "29/12/2023",
            "30/12/2023",
            "31/12/2023",
            "01/01/2024",
            "02/01/2024",
            "03/01/2024",
            "04/01/2024",
            "05/01/2024",
            "06/01/2024",
            "07/01/2024",
            "08/01/2024",
            "09/01/2024",
            "10/01/2024",
            "11/01/2024",
            "12/01/2024",
            "13/01/2024",
            "14/01/2024",
            "15/01/2024",
            "16/01/2024",
            "17/01/2024",
            "18/01/2024",
            "19/01/2024",
            "20/01/2024",
            "21/01/2024",
            "22/01/2024",
            "23/01/2024",
            "24/01/2024",
            "25/01/2024",
            "26/01/2024",
            "27/01/2024",
            "28/01/2024",
            "29/01/2024",
            "30/01/2024",
            "31/01/2024",
            "01/02/2024",
            "02/02/2024",
            "03/02/2024",
            "04/02/2024",
            "05/02/2024",
            "06/02/2024",
            "07/02/2024",
            "08/02/2024",
            "09/02/2024",
            "10/02/2024",
            "11/02/2024",
            "12/02/2024",
            "13/02/2024",
            "14/02/2024",
            "15/02/2024",
            "16/02/2024",
            "17/02/2024",
            "18/02/2024",
            "19/02/2024",
            "20/02/2024",
            "21/02/2024",
            "22/02/2024",
            "23/02/2024",
            "24/02/2024",
            "25/02/2024",
            "26/02/2024",
            "27/02/2024",
            "28/02/2024",
            "29/02/2024",
            "01/03/2024",
            "02/03/2024",
            "03/03/2024",
            "04/03/2024",
            "05/03/2024",
            "06/03/2024",
            "07/03/2024",
            "08/03/2024",
            "09/03/2024",
            "10/03/2024",
            "11/03/2024",
            "12/03/2024",
            "13/03/2024",
            "14/03/2024",
            "15/03/2024",
            "16/03/2024",
            "17/03/2024",
            "18/03/2024",
            "19/03/2024",
            "20/03/2024",
            "21/03/2024",
            "22/03/2024",
            "23/03/2024",
            "24/03/2024",
            "25/03/2024",
            "26/03/2024",
            "27/03/2024",
            "28/03/2024",
            "29/03/2024",
            "30/03/2024",
            "31/03/2024",
            "01/04/2024",
            "02/04/2024",
            "03/04/2024",
            "04/04/2024",
            "05/04/2024",
            "06/04/2024",
            "07/04/2024",
            "08/04/2024",
            "09/04/2024",
            "10/04/2024",
            "11/04/2024",
            "12/04/2024",
            "13/04/2024",
            "14/04/2024",
            "15/04/2024",
            "16/04/2024",
            "17/04/2024",
            "18/04/2024",
            "19/04/2024",
            "20/04/2024",
            "21/04/2024",
            "22/04/2024",
            "23/04/2024",
            "24/04/2024",
            "25/04/2024",
            "26/04/2024",
            "27/04/2024",
            "28/04/2024",
            "29/04/2024",
            "30/04/2024",
            "01/05/2024",
            "02/05/2024",
            "03/05/2024",
            "04/05/2024",
            "05/05/2024",
            "06/05/2024",
            "07/05/2024",
            "08/05/2024",
            "09/05/2024",
            "10/05/2024",
            "11/05/2024",
            "12/05/2024",
            "13/05/2024",
            "14/05/2024",
            "15/05/2024",
            "16/05/2024",
            "17/05/2024",
            "18/05/2024",
            "19/05/2024",
            "20/05/2024",
            "21/05/2024",
            "22/05/2024",
            "23/05/2024",
            "24/05/2024",
            "25/05/2024",
            "26/05/2024",
            "27/05/2024",
            "28/05/2024",
            "29/05/2024",
            "30/05/2024",
            "31/05/2024",
            "01/06/2024",
            "02/06/2024",
            "03/06/2024",
            "04/06/2024",
            "05/06/2024",
            "06/06/2024",
            "07/06/2024",
            "08/06/2024",
            "09/06/2024",
            "10/06/2024",
            "11/06/2024",
            "12/06/2024",
            "13/06/2024",
            "14/06/2024",
            "15/06/2024",
            "16/06/2024",
            "17/06/2024",
            "18/06/2024",
            "19/06/2024",
            "20/06/2024",
            "21/06/2024",
            "22/06/2024",
            "23/06/2024",
            "24/06/2024",
            "25/06/2024",
            "26/06/2024",
            "27/06/2024",
            "28/06/2024",
            "29/06/2024",
            "30/06/2024",
            "01/07/2024",
            "02/07/2024",
            "03/07/2024",
            "04/07/2024",
            "05/07/2024",
            "06/07/2024",
            "07/07/2024",
            "08/07/2024",
            "09/07/2024",
            "10/07/2024",
            "11/07/2024",
            "12/07/2024",
            "13/07/2024",
            "14/07/2024",
            "15/07/2024",
            "16/07/2024",
            "17/07/2024",
            "18/07/2024",
            "19/07/2024",
            "20/07/2024",
            "21/07/2024",
            "22/07/2024",
            "23/07/2024",
            "24/07/2024",
            "25/07/2024",
            "26/07/2024",
            "27/07/2024",
            "28/07/2024",
            "29/07/2024",
            "30/07/2024",
            "31/07/2024",
            "01/08/2024",
            "02/08/2024",
            "03/08/2024",
            "04/08/2024",
            "05/08/2024",
            "06/08/2024",
            "07/08/2024",
            "08/08/2024",
            "09/08/2024",
            "10/08/2024",
            "11/08/2024",
            "12/08/2024",
            "13/08/2024",
            "14/08/2024",
            "15/08/2024",
            "16/08/2024",
            "17/08/2024",
            "18/08/2024",
            "19/08/2024",
            "20/08/2024",
            "21/08/2024",
            "22/08/2024",
            "23/08/2024",
            "24/08/2024",
            "25/08/2024",
            "26/08/2024",
            "27/08/2024",
            "28/08/2024",
            "29/08/2024",
            "30/08/2024",
            "31/08/2024",
            "01/09/2024",
            "02/09/2024",
            "03/09/2024",
            "04/09/2024",
            "05/09/2024",
            "06/09/2024",
            "07/09/2024",
            "08/09/2024",
            "09/09/2024",
            "10/09/2024",
            "11/09/2024",
            "12/09/2024",
            "13/09/2024",
            "14/09/2024",
            "15/09/2024",
            "16/09/2024",
            "17/09/2024",
            "18/09/2024",
            "19/09/2024",
            "20/09/2024",
            "21/09/2024",
            "22/09/2024",
            "23/09/2024",
            "24/09/2024",
            "25/09/2024",
            "26/09/2024",
            "27/09/2024",
            "28/09/2024",
            "29/09/2024",
            "30/09/2024",
            "01/10/2024",
            "02/10/2024",
            "03/10/2024",
            "04/10/2024",
            "05/10/2024",
            "06/10/2024",
            "07/10/2024",
            "08/10/2024",
            "09/10/2024",
            "10/10/2024",
            "11/10/2024"});
            this.ListaDeDatas.Location = new System.Drawing.Point(0, 0);
            this.ListaDeDatas.Name = "ListaDeDatas";
            this.ListaDeDatas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListaDeDatas.Size = new System.Drawing.Size(95, 125);
            this.ListaDeDatas.TabIndex = 9;
            this.ListaDeDatas.SelectedValueChanged += new System.EventHandler(this.ListaDeDatas_SelectedValueChanged);
            // 
            // ContextMenuStripHoje
            // 
            this.ContextMenuStripHoje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hojeToolStripMenuItem});
            this.ContextMenuStripHoje.Name = "ContextMenuStripHoje";
            this.ContextMenuStripHoje.Size = new System.Drawing.Size(100, 26);
            // 
            // hojeToolStripMenuItem
            // 
            this.hojeToolStripMenuItem.Name = "hojeToolStripMenuItem";
            this.hojeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hojeToolStripMenuItem.Text = "Hoje";
            this.hojeToolStripMenuItem.Click += new System.EventHandler(this.hojeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Editar Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DiaMarcadoPretendido
            // 
            this.DiaMarcadoPretendido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "DIAMARCADO", true));
            this.DiaMarcadoPretendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaMarcadoPretendido.Location = new System.Drawing.Point(3, 3);
            this.DiaMarcadoPretendido.Mask = "00/00/0000";
            this.DiaMarcadoPretendido.Name = "DiaMarcadoPretendido";
            this.DiaMarcadoPretendido.Size = new System.Drawing.Size(79, 21);
            this.DiaMarcadoPretendido.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(88, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 73);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TarefasBindingSource, "IND", true));
            this.textBox1.Location = new System.Drawing.Point(608, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.ContextMenuStrip = this.ContextMenuStripVoltar;
            this.PictureBox1.Image = global::BomDia.Properties.Resources.LIGHTOFF;
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(2, 2);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(22, 29);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // MonthCalendarDiamarcado
            // 
            this.MonthCalendarDiamarcado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MonthCalendarDiamarcado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCalendarDiamarcado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCalendarDiamarcado.Location = new System.Drawing.Point(0, 0);
            this.MonthCalendarDiamarcado.Name = "MonthCalendarDiamarcado";
            this.MonthCalendarDiamarcado.TabIndex = 10;
            this.MonthCalendarDiamarcado.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(717, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ITENS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxIntegrador
            // 
            this.CheckBoxIntegrador.AutoSize = true;
            this.CheckBoxIntegrador.BackColor = System.Drawing.Color.SlateBlue;
            this.CheckBoxIntegrador.Checked = true;
            this.CheckBoxIntegrador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxIntegrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxIntegrador.ForeColor = System.Drawing.Color.White;
            this.CheckBoxIntegrador.Location = new System.Drawing.Point(3, 16);
            this.CheckBoxIntegrador.Name = "CheckBoxIntegrador";
            this.CheckBoxIntegrador.Size = new System.Drawing.Size(68, 16);
            this.CheckBoxIntegrador.TabIndex = 10;
            this.CheckBoxIntegrador.Text = "Date filter";
            this.CheckBoxIntegrador.UseVisualStyleBackColor = false;
            this.CheckBoxIntegrador.Click += new System.EventHandler(this.CheckBoxIntegrador_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirToolStripButtonGerenciar});
            this.bindingNavigator1.Location = new System.Drawing.Point(37, 2);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(82, 31);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.TabStop = true;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // AbrirToolStripButtonGerenciar
            // 
            this.AbrirToolStripButtonGerenciar.AutoSize = false;
            this.AbrirToolStripButtonGerenciar.BackColor = System.Drawing.Color.Salmon;
            this.AbrirToolStripButtonGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("AbrirToolStripButtonGerenciar.Image")));
            this.AbrirToolStripButtonGerenciar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AbrirToolStripButtonGerenciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AbrirToolStripButtonGerenciar.Name = "AbrirToolStripButtonGerenciar";
            this.AbrirToolStripButtonGerenciar.Size = new System.Drawing.Size(74, 40);
            this.AbrirToolStripButtonGerenciar.Text = "A&tivar";
            this.AbrirToolStripButtonGerenciar.Click += new System.EventHandler(this.AbrirToolStripButtonGerenciar_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 3000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BindingNavigatorSemana
            // 
            this.BindingNavigatorSemana.AddNewItem = null;
            this.BindingNavigatorSemana.AutoSize = false;
            this.BindingNavigatorSemana.BackColor = System.Drawing.Color.Transparent;
            this.BindingNavigatorSemana.CanOverflow = false;
            this.BindingNavigatorSemana.CountItem = null;
            this.BindingNavigatorSemana.DeleteItem = null;
            this.BindingNavigatorSemana.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigatorSemana.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BindingNavigatorSemana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SemanaToolStripButton});
            this.BindingNavigatorSemana.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.BindingNavigatorSemana.Location = new System.Drawing.Point(94, 0);
            this.BindingNavigatorSemana.MoveFirstItem = null;
            this.BindingNavigatorSemana.MoveLastItem = null;
            this.BindingNavigatorSemana.MoveNextItem = null;
            this.BindingNavigatorSemana.MovePreviousItem = null;
            this.BindingNavigatorSemana.Name = "BindingNavigatorSemana";
            this.BindingNavigatorSemana.PositionItem = null;
            this.BindingNavigatorSemana.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BindingNavigatorSemana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BindingNavigatorSemana.Size = new System.Drawing.Size(55, 41);
            this.BindingNavigatorSemana.TabIndex = 13;
            this.BindingNavigatorSemana.Text = "BindingNavigatorSemana";
            // 
            // SemanaToolStripButton
            // 
            this.SemanaToolStripButton.AutoSize = false;
            this.SemanaToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.SemanaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SemanaToolStripButton.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemanaToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SemanaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SemanaToolStripButton.Image")));
            this.SemanaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SemanaToolStripButton.Name = "SemanaToolStripButton";
            this.SemanaToolStripButton.Size = new System.Drawing.Size(51, 34);
            this.SemanaToolStripButton.Text = "Sem";
            this.SemanaToolStripButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SemanaToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.SemanaToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.SemanaToolStripButton.MouseLeave += new System.EventHandler(this.SemanaToolStripButton_MouseLeave);
            this.SemanaToolStripButton.MouseHover += new System.EventHandler(this.SemanaToolStripButton_MouseHover);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BindingNavigatorSemana, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 44);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // StatusStripBomDia
            // 
            this.StatusStripBomDia.AutoSize = false;
            this.StatusStripBomDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusStripBomDia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSGtoolStripStatusLabel});
            this.StatusStripBomDia.Location = new System.Drawing.Point(0, 0);
            this.StatusStripBomDia.Name = "StatusStripBomDia";
            this.StatusStripBomDia.Size = new System.Drawing.Size(821, 35);
            this.StatusStripBomDia.SizingGrip = false;
            this.StatusStripBomDia.TabIndex = 15;
            this.StatusStripBomDia.Text = "Bom dia.";
            // 
            // MSGtoolStripStatusLabel
            // 
            this.MSGtoolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.MSGtoolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSGtoolStripStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.MSGtoolStripStatusLabel.Name = "MSGtoolStripStatusLabel";
            this.MSGtoolStripStatusLabel.Size = new System.Drawing.Size(59, 30);
            this.MSGtoolStripStatusLabel.Text = "Bom dia.";
            // 
            // DataHoje
            // 
            this.DataHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataHoje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataHoje.Font = new System.Drawing.Font("Myanmar Text", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataHoje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataHoje.Location = new System.Drawing.Point(3, 44);
            this.DataHoje.Name = "DataHoje";
            this.DataHoje.ReadOnly = true;
            this.DataHoje.Size = new System.Drawing.Size(146, 44);
            this.DataHoje.TabIndex = 16;
            this.DataHoje.TabStop = false;
            this.DataHoje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataHoje.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer1.Size = new System.Drawing.Size(955, 481);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.DataHoje);
            this.splitContainer5.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer5.Size = new System.Drawing.Size(955, 101);
            this.splitContainer5.SplitterDistance = 158;
            this.splitContainer5.TabIndex = 11;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.BindingNavigatorSalva);
            this.splitContainer8.Panel2.Controls.Add(this.BindingExclui);
            this.splitContainer8.Size = new System.Drawing.Size(793, 101);
            this.splitContainer8.SplitterDistance = 706;
            this.splitContainer8.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.LightYellow;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.OQuePretendido, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.BindingNavigatorNovo, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Enabled = false;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(706, 101);
            this.tableLayoutPanel6.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(429, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Limite";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.13295F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.86705F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.DiaMarcadoPretendido, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(429, 25);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(173, 73);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer7.Size = new System.Drawing.Size(955, 376);
            this.splitContainer7.SplitterDistance = 337;
            this.splitContainer7.TabIndex = 12;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer3.Size = new System.Drawing.Size(955, 337);
            this.splitContainer3.SplitterDistance = 228;
            this.splitContainer3.TabIndex = 11;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.MonthCalendarDiamarcado);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer4.Size = new System.Drawing.Size(228, 337);
            this.splitContainer4.SplitterDistance = 163;
            this.splitContainer4.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.splitContainer9, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 170);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemPrioridadeDataGridViewTextBoxColumn,
            this.denominationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.PrioridadesBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(121, 164);
            this.dataGridView2.TabIndex = 10;
            // 
            // itemPrioridadeDataGridViewTextBoxColumn
            // 
            this.itemPrioridadeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrioridade";
            this.itemPrioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.itemPrioridadeDataGridViewTextBoxColumn.Name = "itemPrioridadeDataGridViewTextBoxColumn";
            this.itemPrioridadeDataGridViewTextBoxColumn.Width = 25;
            // 
            // denominationDataGridViewTextBoxColumn
            // 
            this.denominationDataGridViewTextBoxColumn.DataPropertyName = "Denomination";
            this.denominationDataGridViewTextBoxColumn.HeaderText = "Denomination";
            this.denominationDataGridViewTextBoxColumn.Name = "denominationDataGridViewTextBoxColumn";
            this.denominationDataGridViewTextBoxColumn.Width = 80;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer9.Location = new System.Drawing.Point(130, 3);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.ListaDeDatas);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.tableLayoutPanel8);
            this.splitContainer9.Panel2MinSize = 20;
            this.splitContainer9.Size = new System.Drawing.Size(95, 164);
            this.splitContainer9.SplitterDistance = 125;
            this.splitContainer9.TabIndex = 11;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer6.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer6_Panel1_Paint);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer6.Size = new System.Drawing.Size(723, 337);
            this.splitContainer6.SplitterDistance = 308;
            this.splitContainer6.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 308);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BindingNavegador, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BindingNavigatorMigrar, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(723, 25);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.StatusStripBomDia);
            this.splitContainer2.Panel2.Controls.Add(this.INDPretendido);
            this.splitContainer2.Panel2.Controls.Add(this.DetalheQuando);
            this.splitContainer2.Panel2.Controls.Add(this.DetalhePorQue);
            this.splitContainer2.Size = new System.Drawing.Size(955, 35);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 18;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Controls.Add(this.PictureBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bindingNavigator1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(130, 35);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.CheckBoxIntegrador, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.DiaBomDiaLabel, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(95, 35);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // DiaBomDiaLabel
            // 
            this.DiaBomDiaLabel.AutoSize = true;
            this.DiaBomDiaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiaBomDiaLabel.Location = new System.Drawing.Point(3, 0);
            this.DiaBomDiaLabel.Name = "DiaBomDiaLabel";
            this.DiaBomDiaLabel.Size = new System.Drawing.Size(89, 13);
            this.DiaBomDiaLabel.TabIndex = 11;
            this.DiaBomDiaLabel.Text = "Dia bom dia";
            this.DiaBomDiaLabel.UseCompatibleTextRendering = true;
            // 
            // BomDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(955, 481);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "BomDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Min";
            this.Text = "BomDia App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BomDia_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BomDia_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BomDiaTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadesDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarefasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadesBindingSource)).EndInit();
            this.ChaveadorContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorNovo)).EndInit();
            this.BindingNavigatorNovo.ResumeLayout(false);
            this.BindingNavigatorNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingExclui)).EndInit();
            this.BindingExclui.ResumeLayout(false);
            this.BindingExclui.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorSalva)).EndInit();
            this.BindingNavigatorSalva.ResumeLayout(false);
            this.BindingNavigatorSalva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorMigrar)).EndInit();
            this.BindingNavigatorMigrar.ResumeLayout(false);
            this.BindingNavigatorMigrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavegador)).EndInit();
            this.BindingNavegador.ResumeLayout(false);
            this.BindingNavegador.PerformLayout();
            this.ContextMenuStripVoltar.ResumeLayout(false);
            this.ContextMenuStripHoje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorSemana)).EndInit();
            this.BindingNavigatorSemana.ResumeLayout(false);
            this.BindingNavigatorSemana.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.StatusStripBomDia.ResumeLayout(false);
            this.StatusStripBomDia.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet TarefasDataSet;
        private System.Windows.Forms.BindingSource TarefasBindingSource;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Data.DataTable BomDiaTarefas;
        private System.Data.DataColumn IND;
        private System.Data.DataColumn QUANDO;
        private System.Data.DataColumn OQUE;
        private System.Data.DataColumn PORQUE;
        private System.Data.DataColumn CRITÉRIO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip ChaveadorContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cortinaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox OQuePretendido;
        private System.Windows.Forms.BindingNavigator BindingNavigatorNovo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.TextBox INDPretendido;
        private System.Windows.Forms.TextBox DetalheQuando;
        private System.Windows.Forms.TextBox DetalhePorQue;
        private System.Windows.Forms.BindingNavigator BindingNavegador;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.BindingNavigator BindingExclui;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ListBox ListaDeDatas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton AbrirToolStripButtonGerenciar;
        private System.Windows.Forms.CheckBox CheckBoxIntegrador;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.BindingNavigator BindingNavigatorMigrar;
        private System.Windows.Forms.ToolStripButton MigrarToolStripButton;
        private System.Data.DataColumn PESO;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripVoltar;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingNavigator BindingNavigatorSemana;
        private System.Windows.Forms.ToolStripButton SemanaToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip StatusStripBomDia;
        private System.Windows.Forms.ToolStripStatusLabel MSGtoolStripStatusLabel;
        private System.Windows.Forms.BindingNavigator BindingNavigatorSalva;
        private System.Windows.Forms.ToolStripButton SalvarToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripHoje;
        private System.Windows.Forms.ToolStripMenuItem hojeToolStripMenuItem;
        private System.Data.DataColumn DIAMARCADO;
        private System.Windows.Forms.MonthCalendar MonthCalendarDiamarcado;
        private System.Windows.Forms.MaskedTextBox DiaMarcadoPretendido;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DataHoje;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Data.DataTable PrioridadesDataTable;
        private System.Data.DataColumn ItemPrioridadeDataColumn;
        private System.Data.DataColumn DenominationDataColumn;
        private System.Windows.Forms.BindingSource PrioridadesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pORQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cRITÉRIODataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label DiaBomDiaLabel;
    }
}

