namespace Project_DasStruct
{
    partial class FormMain
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
            this.labelJenisSort = new System.Windows.Forms.Label();
            this.comboBoxJenisSort = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxInitialNum = new System.Windows.Forms.ListBox();
            this.listBoxHasilSort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWaktuSorting = new System.Windows.Forms.Label();
            this.labelTotalData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.buttonAsc = new System.Windows.Forms.Button();
            this.buttonDsc = new System.Windows.Forms.Button();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJenisSort
            // 
            this.labelJenisSort.AutoSize = true;
            this.labelJenisSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisSort.Location = new System.Drawing.Point(19, 18);
            this.labelJenisSort.Name = "labelJenisSort";
            this.labelJenisSort.Size = new System.Drawing.Size(123, 25);
            this.labelJenisSort.TabIndex = 0;
            this.labelJenisSort.Text = "Jenis Sort :";
            // 
            // comboBoxJenisSort
            // 
            this.comboBoxJenisSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJenisSort.FormattingEnabled = true;
            this.comboBoxJenisSort.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort",
            "Heap Sort",
            "Radix Sort",
            "Shell Sort"});
            this.comboBoxJenisSort.Location = new System.Drawing.Point(23, 52);
            this.comboBoxJenisSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJenisSort.Name = "comboBoxJenisSort";
            this.comboBoxJenisSort.Size = new System.Drawing.Size(247, 30);
            this.comboBoxJenisSort.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(288, 42);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(213, 47);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate Angka Random";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(516, 42);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(213, 47);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxInitialNum
            // 
            this.listBoxInitialNum.FormattingEnabled = true;
            this.listBoxInitialNum.ItemHeight = 16;
            this.listBoxInitialNum.Location = new System.Drawing.Point(23, 144);
            this.listBoxInitialNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxInitialNum.Name = "listBoxInitialNum";
            this.listBoxInitialNum.Size = new System.Drawing.Size(1248, 164);
            this.listBoxInitialNum.TabIndex = 4;
            // 
            // listBoxHasilSort
            // 
            this.listBoxHasilSort.FormattingEnabled = true;
            this.listBoxHasilSort.ItemHeight = 16;
            this.listBoxHasilSort.Location = new System.Drawing.Point(23, 362);
            this.listBoxHasilSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxHasilSort.Name = "listBoxHasilSort";
            this.listBoxHasilSort.Size = new System.Drawing.Size(1248, 164);
            this.listBoxHasilSort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Innitial Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorted Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time :";
            // 
            // labelWaktuSorting
            // 
            this.labelWaktuSorting.AutoSize = true;
            this.labelWaktuSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaktuSorting.Location = new System.Drawing.Point(101, 555);
            this.labelWaktuSorting.Name = "labelWaktuSorting";
            this.labelWaktuSorting.Size = new System.Drawing.Size(60, 25);
            this.labelWaktuSorting.TabIndex = 9;
            this.labelWaktuSorting.Text = "0000";
            // 
            // labelTotalData
            // 
            this.labelTotalData.AutoSize = true;
            this.labelTotalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalData.Location = new System.Drawing.Point(420, 555);
            this.labelTotalData.Name = "labelTotalData";
            this.labelTotalData.Size = new System.Drawing.Size(60, 25);
            this.labelTotalData.TabIndex = 10;
            this.labelTotalData.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Data :";
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.buttonAsc);
            this.groupBoxSort.Controls.Add(this.buttonDsc);
            this.groupBoxSort.Location = new System.Drawing.Point(805, 26);
            this.groupBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSort.Size = new System.Drawing.Size(407, 80);
            this.groupBoxSort.TabIndex = 12;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Ascending atau Descending";
            // 
            // buttonAsc
            // 
            this.buttonAsc.Location = new System.Drawing.Point(210, 30);
            this.buttonAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsc.Name = "buttonAsc";
            this.buttonAsc.Size = new System.Drawing.Size(187, 35);
            this.buttonAsc.TabIndex = 1;
            this.buttonAsc.Text = "Ascending";
            this.buttonAsc.UseVisualStyleBackColor = true;
            this.buttonAsc.Click += new System.EventHandler(this.buttonAsc_Click);
            // 
            // buttonDsc
            // 
            this.buttonDsc.Location = new System.Drawing.Point(5, 30);
            this.buttonDsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDsc.Name = "buttonDsc";
            this.buttonDsc.Size = new System.Drawing.Size(187, 35);
            this.buttonDsc.TabIndex = 0;
            this.buttonDsc.Text = "Descending";
            this.buttonDsc.UseVisualStyleBackColor = true;
            this.buttonDsc.Click += new System.EventHandler(this.buttonDsc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 617);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalData);
            this.Controls.Add(this.labelWaktuSorting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHasilSort);
            this.Controls.Add(this.listBoxInitialNum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxJenisSort);
            this.Controls.Add(this.labelJenisSort);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Sorting App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJenisSort;
        private System.Windows.Forms.ComboBox comboBoxJenisSort;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxInitialNum;
        private System.Windows.Forms.ListBox listBoxHasilSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWaktuSorting;
        private System.Windows.Forms.Label labelTotalData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button buttonAsc;
        private System.Windows.Forms.Button buttonDsc;
    }
}

