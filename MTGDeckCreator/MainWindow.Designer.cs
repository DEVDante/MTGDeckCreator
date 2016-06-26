namespace MTGDeckCreator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.delete4Button = new System.Windows.Forms.Button();
            this.add4Button = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cardLibraryView = new System.Windows.Forms.DataGridView();
            this.deckView = new System.Windows.Forms.DataGridView();
            this.CardViewPanel = new System.Windows.Forms.Panel();
            this.deckStats = new System.Windows.Forms.GroupBox();
            this.manaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.otherCardsLabel = new System.Windows.Forms.Label();
            this.creatureCardsLabel = new System.Windows.Forms.Label();
            this.landCardsLabel = new System.Windows.Forms.Label();
            this.cardsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokKolumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nazwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardLibraryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckView)).BeginInit();
            this.deckStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manaChart)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPanel.Controls.Add(this.delete4Button);
            this.buttonPanel.Controls.Add(this.add4Button);
            this.buttonPanel.Controls.Add(this.deleteButton);
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPanel.Location = new System.Drawing.Point(0, 541);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1028, 33);
            this.buttonPanel.TabIndex = 2;
            // 
            // delete4Button
            // 
            this.delete4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.delete4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete4Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete4Button.Location = new System.Drawing.Point(247, 4);
            this.delete4Button.Name = "delete4Button";
            this.delete4Button.Size = new System.Drawing.Size(75, 23);
            this.delete4Button.TabIndex = 3;
            this.delete4Button.Text = "Delete 4";
            this.delete4Button.UseVisualStyleBackColor = false;
            this.delete4Button.Click += new System.EventHandler(this.delete4Button_Click);
            // 
            // add4Button
            // 
            this.add4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.add4Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add4Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add4Button.Location = new System.Drawing.Point(166, 4);
            this.add4Button.Name = "add4Button";
            this.add4Button.Size = new System.Drawing.Size(75, 23);
            this.add4Button.TabIndex = 2;
            this.add4Button.Text = "Add 4";
            this.add4Button.UseVisualStyleBackColor = false;
            this.add4Button.Click += new System.EventHandler(this.add4Button_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButton.Location = new System.Drawing.Point(85, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainer1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cardLibraryView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deckView);
            this.splitContainer1.Size = new System.Drawing.Size(771, 512);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // cardLibraryView
            // 
            this.cardLibraryView.AllowUserToAddRows = false;
            this.cardLibraryView.AllowUserToDeleteRows = false;
            this.cardLibraryView.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.cardLibraryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.cardLibraryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cardLibraryView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.cardLibraryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardLibraryView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardLibraryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.cardLibraryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cardLibraryView.DefaultCellStyle = dataGridViewCellStyle21;
            this.cardLibraryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLibraryView.Location = new System.Drawing.Point(0, 0);
            this.cardLibraryView.Name = "cardLibraryView";
            this.cardLibraryView.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardLibraryView.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.cardLibraryView.Size = new System.Drawing.Size(771, 263);
            this.cardLibraryView.TabIndex = 0;
            this.cardLibraryView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardLibraryView_KeyPress);
            // 
            // deckView
            // 
            this.deckView.AllowUserToAddRows = false;
            this.deckView.AllowUserToDeleteRows = false;
            this.deckView.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.deckView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.deckView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deckView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deckView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.deckView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deckView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deckView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.deckView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deckView.DefaultCellStyle = dataGridViewCellStyle25;
            this.deckView.Location = new System.Drawing.Point(2, 0);
            this.deckView.Name = "deckView";
            this.deckView.ReadOnly = true;
            this.deckView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deckView.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.deckView.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.deckView.Size = new System.Drawing.Size(767, 245);
            this.deckView.TabIndex = 0;
            this.deckView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.deckView_RowEnter);
            // 
            // CardViewPanel
            // 
            this.CardViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CardViewPanel.Location = new System.Drawing.Point(793, 35);
            this.CardViewPanel.Name = "CardViewPanel";
            this.CardViewPanel.Size = new System.Drawing.Size(223, 298);
            this.CardViewPanel.TabIndex = 1;
            // 
            // deckStats
            // 
            this.deckStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deckStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deckStats.Controls.Add(this.manaChart);
            this.deckStats.Controls.Add(this.otherCardsLabel);
            this.deckStats.Controls.Add(this.creatureCardsLabel);
            this.deckStats.Controls.Add(this.landCardsLabel);
            this.deckStats.Controls.Add(this.cardsLabel);
            this.deckStats.Controls.Add(this.label5);
            this.deckStats.Controls.Add(this.label4);
            this.deckStats.Controls.Add(this.label3);
            this.deckStats.Controls.Add(this.label2);
            this.deckStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deckStats.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deckStats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deckStats.Location = new System.Drawing.Point(793, 351);
            this.deckStats.Name = "deckStats";
            this.deckStats.Size = new System.Drawing.Size(223, 188);
            this.deckStats.TabIndex = 0;
            this.deckStats.TabStop = false;
            this.deckStats.Text = "Statistics";
            // 
            // manaChart
            // 
            this.manaChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manaChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea3.Name = "ChartArea1";
            this.manaChart.ChartAreas.Add(chartArea3);
            this.manaChart.Location = new System.Drawing.Point(0, 21);
            this.manaChart.Name = "manaChart";
            this.manaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.manaChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))))};
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.manaChart.Series.Add(series3);
            this.manaChart.Size = new System.Drawing.Size(211, 111);
            this.manaChart.TabIndex = 15;
            this.manaChart.TabStop = false;
            this.manaChart.Text = "Mana";
            title3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title3.Name = "Title1";
            title3.Text = "Mana";
            this.manaChart.Titles.Add(title3);
            // 
            // otherCardsLabel
            // 
            this.otherCardsLabel.AutoSize = true;
            this.otherCardsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.otherCardsLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otherCardsLabel.Location = new System.Drawing.Point(156, 168);
            this.otherCardsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.otherCardsLabel.Name = "otherCardsLabel";
            this.otherCardsLabel.Size = new System.Drawing.Size(22, 18);
            this.otherCardsLabel.TabIndex = 14;
            this.otherCardsLabel.Text = " 0";
            // 
            // creatureCardsLabel
            // 
            this.creatureCardsLabel.AutoSize = true;
            this.creatureCardsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creatureCardsLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creatureCardsLabel.Location = new System.Drawing.Point(156, 148);
            this.creatureCardsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.creatureCardsLabel.Name = "creatureCardsLabel";
            this.creatureCardsLabel.Size = new System.Drawing.Size(22, 18);
            this.creatureCardsLabel.TabIndex = 13;
            this.creatureCardsLabel.Text = " 0";
            // 
            // landCardsLabel
            // 
            this.landCardsLabel.AutoSize = true;
            this.landCardsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.landCardsLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.landCardsLabel.Location = new System.Drawing.Point(156, 128);
            this.landCardsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.landCardsLabel.Name = "landCardsLabel";
            this.landCardsLabel.Size = new System.Drawing.Size(22, 18);
            this.landCardsLabel.TabIndex = 12;
            this.landCardsLabel.Text = " 0";
            // 
            // cardsLabel
            // 
            this.cardsLabel.AutoSize = true;
            this.cardsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardsLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cardsLabel.Location = new System.Drawing.Point(98, 102);
            this.cardsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.cardsLabel.Name = "cardsLabel";
            this.cardsLabel.Size = new System.Drawing.Size(17, 18);
            this.cardsLabel.TabIndex = 11;
            this.cardsLabel.Text = "o";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "* Other:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Creature cards: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Land cards: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cards: ";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1028, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.plikToolStripMenuItem.Text = "File";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otwórzToolStripMenuItem.Text = "Open";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zapiszToolStripMenuItem.Text = "Save";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opcjeToolStripMenuItem.Text = "Options";
            this.opcjeToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // widokKolumnToolStripMenuItem
            // 
            this.widokKolumnToolStripMenuItem.Name = "widokKolumnToolStripMenuItem";
            this.widokKolumnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // nazwaToolStripMenuItem
            // 
            this.nazwaToolStripMenuItem.Name = "nazwaToolStripMenuItem";
            this.nazwaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // typToolStripMenuItem
            // 
            this.typToolStripMenuItem.Name = "typToolStripMenuItem";
            this.typToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // subtypToolStripMenuItem
            // 
            this.subtypToolStripMenuItem.Name = "subtypToolStripMenuItem";
            this.subtypToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 574);
            this.Controls.Add(this.deckStats);
            this.Controls.Add(this.CardViewPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1027, 595);
            this.Name = "MainWindow";
            this.Text = "MTGDeckCreator";
            this.buttonPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardLibraryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckView)).EndInit();
            this.deckStats.ResumeLayout(false);
            this.deckStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manaChart)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel CardViewPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.DataGridView cardLibraryView;
        private System.Windows.Forms.DataGridView deckView;
        private System.Windows.Forms.GroupBox deckStats;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button delete4Button;
        private System.Windows.Forms.Button add4Button;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem widokKolumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nazwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtypToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label otherCardsLabel;
        private System.Windows.Forms.Label creatureCardsLabel;
        private System.Windows.Forms.Label landCardsLabel;
        private System.Windows.Forms.Label cardsLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart manaChart;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

