namespace WeatherAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listbox = new ListBox();
            dataGridTable = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Temperature = new DataGridViewTextBoxColumn();
            temperatureAlarm = new PictureBox();
            textBoxResult = new TextBox();
            TimerBoc = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)temperatureAlarm).BeginInit();
            SuspendLayout();
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.HorizontalScrollbar = true;
            listbox.Location = new Point(63, 21);
            listbox.Name = "listbox";
            listbox.Size = new Size(485, 224);
            listbox.TabIndex = 0;
            listbox.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // dataGridTable
            // 
            dataGridTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Columns.AddRange(new DataGridViewColumn[] { Date, Temperature });
            dataGridTable.Location = new Point(63, 297);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.RowHeadersWidth = 51;
            dataGridTable.Size = new Size(371, 188);
            dataGridTable.TabIndex = 2;
            dataGridTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Date
            // 
            Date.Frozen = true;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 70;
            // 
            // Temperature
            // 
            Temperature.HeaderText = "Temperature";
            Temperature.MinimumWidth = 6;
            Temperature.Name = "Temperature";
            Temperature.ReadOnly = true;
            Temperature.Width = 122;
            // 
            // temperatureAlarm
            // 
            temperatureAlarm.BackColor = Color.White;
            temperatureAlarm.BorderStyle = BorderStyle.FixedSingle;
            temperatureAlarm.Location = new Point(681, 252);
            temperatureAlarm.Name = "temperatureAlarm";
            temperatureAlarm.Size = new Size(177, 43);
            temperatureAlarm.TabIndex = 3;
            temperatureAlarm.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(654, 312);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(241, 27);
            textBoxResult.TabIndex = 4;
            // 
            // TimerBoc
            // 
            TimerBoc.Location = new Point(698, 115);
            TimerBoc.Name = "TimerBoc";
            TimerBoc.Size = new Size(125, 27);
            TimerBoc.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 586);
            Controls.Add(TimerBoc);
            Controls.Add(textBoxResult);
            Controls.Add(temperatureAlarm);
            Controls.Add(dataGridTable);
            Controls.Add(listbox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)temperatureAlarm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox;
        private DataGridView dataGridTable;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Temperature;
        private PictureBox temperatureAlarm;
        private TextBox textBoxResult;
        private TextBox TimerBoc;
        private System.Windows.Forms.Timer timer1;
    }
}
