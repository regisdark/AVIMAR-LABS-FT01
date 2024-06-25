namespace AVIMAR_LABS_FT01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnSimulate = new Button();
            NumCycCount = new NumericUpDown();
            label3 = new Label();
            NumIntRate = new NumericUpDown();
            label2 = new Label();
            numCapital = new NumericUpDown();
            label1 = new Label();
            dtSimulation = new DataGridView();
            CycleNo = new DataGridViewTextBoxColumn();
            Profit = new DataGridViewTextBoxColumn();
            Capital = new DataGridViewTextBoxColumn();
            label4 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            groupBox3 = new GroupBox();
            rTextlog = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumCycCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumIntRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtSimulation).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSimulate);
            groupBox1.Controls.Add(NumCycCount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(NumIntRate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numCapital);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(913, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // btnSimulate
            // 
            btnSimulate.Location = new Point(777, 24);
            btnSimulate.Name = "btnSimulate";
            btnSimulate.Size = new Size(130, 23);
            btnSimulate.TabIndex = 6;
            btnSimulate.Text = "Simulate";
            btnSimulate.UseVisualStyleBackColor = true;
            btnSimulate.Click += btnSimulate_Click;
            // 
            // NumCycCount
            // 
            NumCycCount.Location = new Point(605, 26);
            NumCycCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NumCycCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumCycCount.Name = "NumCycCount";
            NumCycCount.Size = new Size(166, 23);
            NumCycCount.TabIndex = 5;
            NumCycCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 28);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Cycle Count:";
            // 
            // NumIntRate
            // 
            NumIntRate.Location = new Point(348, 26);
            NumIntRate.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            NumIntRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumIntRate.Name = "NumIntRate";
            NumIntRate.Size = new Size(166, 23);
            NumIntRate.TabIndex = 3;
            NumIntRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 28);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Interest Rate:";
            // 
            // numCapital
            // 
            numCapital.Location = new Point(91, 26);
            numCapital.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numCapital.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapital.Name = "numCapital";
            numCapital.Size = new Size(166, 23);
            numCapital.TabIndex = 1;
            numCapital.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Initial Capital:";
            // 
            // dtSimulation
            // 
            dtSimulation.AllowUserToAddRows = false;
            dtSimulation.AllowUserToDeleteRows = false;
            dtSimulation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSimulation.Columns.AddRange(new DataGridViewColumn[] { CycleNo, Profit, Capital });
            dtSimulation.Location = new Point(18, 79);
            dtSimulation.Name = "dtSimulation";
            dtSimulation.ReadOnly = true;
            dtSimulation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtSimulation.Size = new Size(438, 343);
            dtSimulation.TabIndex = 1;
            // 
            // CycleNo
            // 
            CycleNo.HeaderText = "Cycle No";
            CycleNo.Name = "CycleNo";
            CycleNo.ReadOnly = true;
            CycleNo.Width = 80;
            // 
            // Profit
            // 
            Profit.HeaderText = "Profit";
            Profit.Name = "Profit";
            Profit.ReadOnly = true;
            Profit.Width = 155;
            // 
            // Capital
            // 
            Capital.HeaderText = "Capital";
            Capital.Name = "Capital";
            Capital.ReadOnly = true;
            Capital.Width = 155;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 433);
            label4.Name = "label4";
            label4.Size = new Size(186, 15);
            label4.TabIndex = 2;
            label4.Text = "AVIMAR Labs Free Tools Dev Team";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(462, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 122);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Application Tutorial";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "1.- Enter Initial Capital for simulation (min.- 1)", "2.- Enter expected interest rate (min.- 1)", "3.- Enter cycle count (years, monts or days)", "4.- Press Simulate button" });
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(445, 79);
            listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rTextlog);
            groupBox3.Location = new Point(462, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(457, 215);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log";
            // 
            // rTextlog
            // 
            rTextlog.Location = new Point(6, 22);
            rTextlog.Name = "rTextlog";
            rTextlog.ReadOnly = true;
            rTextlog.Size = new Size(445, 187);
            rTextlog.TabIndex = 0;
            rTextlog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 457);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(dtSimulation);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interest Rate Simulator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumCycCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumIntRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapital).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtSimulation).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numCapital;
        private NumericUpDown NumIntRate;
        private Label label2;
        private NumericUpDown NumCycCount;
        private Label label3;
        private Button btnSimulate;
        private DataGridView dtSimulation;
        private Label label4;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private RichTextBox rTextlog;
        private DataGridViewTextBoxColumn CycleNo;
        private DataGridViewTextBoxColumn Profit;
        private DataGridViewTextBoxColumn Capital;
    }
}
