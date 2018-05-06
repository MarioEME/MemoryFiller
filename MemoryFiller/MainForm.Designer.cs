namespace MemoryFiller
{
    partial class MainForm
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
            this.sizeNUD = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.scaleDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.historyDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeNUD
            // 
            this.sizeNUD.DecimalPlaces = 2;
            this.sizeNUD.Location = new System.Drawing.Point(11, 19);
            this.sizeNUD.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.sizeNUD.Name = "sizeNUD";
            this.sizeNUD.Size = new System.Drawing.Size(112, 20);
            this.sizeNUD.TabIndex = 0;
            this.sizeNUD.ThousandsSeparator = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(223, 16);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(241, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(57, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // scaleDropDown
            // 
            this.scaleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaleDropDown.FormattingEnabled = true;
            this.scaleDropDown.Items.AddRange(new object[] {
            "Bytes",
            "Kilobytes",
            "Megabytes",
            "Gigabytes"});
            this.scaleDropDown.Location = new System.Drawing.Point(129, 18);
            this.scaleDropDown.Name = "scaleDropDown";
            this.scaleDropDown.Size = new System.Drawing.Size(106, 21);
            this.scaleDropDown.TabIndex = 3;
            this.scaleDropDown.SelectedIndexChanged += new System.EventHandler(this.scaleDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(107, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(191, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "label3";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historyDataGrid
            // 
            this.historyDataGrid.AllowUserToAddRows = false;
            this.historyDataGrid.AllowUserToDeleteRows = false;
            this.historyDataGrid.AllowUserToResizeRows = false;
            this.historyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Size});
            this.historyDataGrid.Location = new System.Drawing.Point(11, 19);
            this.historyDataGrid.Name = "historyDataGrid";
            this.historyDataGrid.RowHeadersVisible = false;
            this.historyDataGrid.Size = new System.Drawing.Size(287, 132);
            this.historyDataGrid.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Item1";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Item2";
            this.Size.FillWeight = 182F;
            this.Size.HeaderText = "Size (Bytes)";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 182;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.historyDataGrid);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 175);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sizeNUD);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.scaleDropDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 52);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 306);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Memory Filler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sizeNUD;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox scaleDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView historyDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
    }
}

