namespace StasOOP18
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.task1_display = new System.Windows.Forms.Button();
            this.task1_sort = new System.Windows.Forms.Button();
            this.txt1index = new System.Windows.Forms.TextBox();
            this.task1_b = new System.Windows.Forms.Button();
            this.txt1value = new System.Windows.Forms.TextBox();
            this.task1_a = new System.Windows.Forms.Button();
            this.task1_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.task2_display3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.task2_display2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt2thisCol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.task2_display1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt2thisRow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.task2_j = new System.Windows.Forms.Label();
            this.txt2cols = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2rows = new System.Windows.Forms.TextBox();
            this.txt2value = new System.Windows.Forms.TextBox();
            this.rask2_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "index";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 282);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.task1_display);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.task1_sort);
            this.tabPage1.Controls.Add(this.txt1index);
            this.tabPage1.Controls.Add(this.task1_b);
            this.tabPage1.Controls.Add(this.txt1value);
            this.tabPage1.Controls.Add(this.task1_a);
            this.tabPage1.Controls.Add(this.task1_add);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // task1_display
            // 
            this.task1_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_display.Location = new System.Drawing.Point(48, 157);
            this.task1_display.Name = "task1_display";
            this.task1_display.Size = new System.Drawing.Size(240, 35);
            this.task1_display.TabIndex = 9;
            this.task1_display.Text = "вивід";
            this.task1_display.UseVisualStyleBackColor = true;
            this.task1_display.Click += new System.EventHandler(this.task1_display_Click);
            // 
            // task1_sort
            // 
            this.task1_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_sort.Location = new System.Drawing.Point(214, 107);
            this.task1_sort.Name = "task1_sort";
            this.task1_sort.Size = new System.Drawing.Size(74, 35);
            this.task1_sort.TabIndex = 10;
            this.task1_sort.Text = "сорт";
            this.task1_sort.UseVisualStyleBackColor = true;
            this.task1_sort.Click += new System.EventHandler(this.task1_sort_Click);
            // 
            // txt1index
            // 
            this.txt1index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1index.Location = new System.Drawing.Point(48, 54);
            this.txt1index.Name = "txt1index";
            this.txt1index.Size = new System.Drawing.Size(58, 26);
            this.txt1index.TabIndex = 1;
            // 
            // task1_b
            // 
            this.task1_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_b.Location = new System.Drawing.Point(133, 107);
            this.task1_b.Name = "task1_b";
            this.task1_b.Size = new System.Drawing.Size(74, 35);
            this.task1_b.TabIndex = 8;
            this.task1_b.Text = "б)";
            this.task1_b.UseVisualStyleBackColor = true;
            this.task1_b.Click += new System.EventHandler(this.task1_b_Click);
            // 
            // txt1value
            // 
            this.txt1value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1value.Location = new System.Drawing.Point(123, 54);
            this.txt1value.Name = "txt1value";
            this.txt1value.Size = new System.Drawing.Size(58, 26);
            this.txt1value.TabIndex = 3;
            // 
            // task1_a
            // 
            this.task1_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_a.Location = new System.Drawing.Point(48, 107);
            this.task1_a.Name = "task1_a";
            this.task1_a.Size = new System.Drawing.Size(79, 35);
            this.task1_a.TabIndex = 7;
            this.task1_a.Text = "а)";
            this.task1_a.UseVisualStyleBackColor = true;
            this.task1_a.Click += new System.EventHandler(this.task1_a_Click);
            // 
            // task1_add
            // 
            this.task1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_add.Location = new System.Drawing.Point(199, 55);
            this.task1_add.Name = "task1_add";
            this.task1_add.Size = new System.Drawing.Size(89, 25);
            this.task1_add.TabIndex = 4;
            this.task1_add.Text = "Додати";
            this.task1_add.UseVisualStyleBackColor = true;
            this.task1_add.Click += new System.EventHandler(this.task1_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(129, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "value";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.task2_display3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.task2_display2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt2thisCol);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.task2_display1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt2thisRow);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.task2_j);
            this.tabPage2.Controls.Add(this.txt2cols);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt2rows);
            this.tabPage2.Controls.Add(this.txt2value);
            this.tabPage2.Controls.Add(this.rask2_add);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // task2_display3
            // 
            this.task2_display3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2_display3.Location = new System.Drawing.Point(224, 186);
            this.task2_display3.Name = "task2_display3";
            this.task2_display3.Size = new System.Drawing.Size(89, 25);
            this.task2_display3.TabIndex = 25;
            this.task2_display3.Text = "Вивід";
            this.task2_display3.UseVisualStyleBackColor = true;
            this.task2_display3.Click += new System.EventHandler(this.task2_display3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "всю матрицю";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(22, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Вивести";
            // 
            // task2_display2
            // 
            this.task2_display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2_display2.Location = new System.Drawing.Point(224, 155);
            this.task2_display2.Name = "task2_display2";
            this.task2_display2.Size = new System.Drawing.Size(89, 25);
            this.task2_display2.TabIndex = 21;
            this.task2_display2.Text = "Вивід";
            this.task2_display2.UseVisualStyleBackColor = true;
            this.task2_display2.Click += new System.EventHandler(this.task2_display2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(139, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "-й стовп";
            // 
            // txt2thisCol
            // 
            this.txt2thisCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt2thisCol.Location = new System.Drawing.Point(103, 154);
            this.txt2thisCol.Name = "txt2thisCol";
            this.txt2thisCol.Size = new System.Drawing.Size(33, 26);
            this.txt2thisCol.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вивести";
            // 
            // task2_display1
            // 
            this.task2_display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2_display1.Location = new System.Drawing.Point(224, 124);
            this.task2_display1.Name = "task2_display1";
            this.task2_display1.Size = new System.Drawing.Size(89, 25);
            this.task2_display1.TabIndex = 17;
            this.task2_display1.Text = "Вивід";
            this.task2_display1.UseVisualStyleBackColor = true;
            this.task2_display1.Click += new System.EventHandler(this.task2_display1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(139, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "-й рядок";
            // 
            // txt2thisRow
            // 
            this.txt2thisRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt2thisRow.Location = new System.Drawing.Point(103, 123);
            this.txt2thisRow.Name = "txt2thisRow";
            this.txt2thisRow.Size = new System.Drawing.Size(33, 26);
            this.txt2thisRow.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вивести";
            // 
            // task2_j
            // 
            this.task2_j.AutoSize = true;
            this.task2_j.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2_j.Location = new System.Drawing.Point(105, 26);
            this.task2_j.Name = "task2_j";
            this.task2_j.Size = new System.Drawing.Size(37, 20);
            this.task2_j.TabIndex = 13;
            this.task2_j.Text = "cols";
            // 
            // txt2cols
            // 
            this.txt2cols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt2cols.Location = new System.Drawing.Point(96, 49);
            this.txt2cols.Name = "txt2cols";
            this.txt2cols.Size = new System.Drawing.Size(58, 26);
            this.txt2cols.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "rows";
            // 
            // txt2rows
            // 
            this.txt2rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt2rows.Location = new System.Drawing.Point(32, 48);
            this.txt2rows.Name = "txt2rows";
            this.txt2rows.Size = new System.Drawing.Size(58, 26);
            this.txt2rows.TabIndex = 7;
            // 
            // txt2value
            // 
            this.txt2value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt2value.Location = new System.Drawing.Point(160, 48);
            this.txt2value.Name = "txt2value";
            this.txt2value.Size = new System.Drawing.Size(58, 26);
            this.txt2value.TabIndex = 8;
            // 
            // rask2_add
            // 
            this.rask2_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rask2_add.Location = new System.Drawing.Point(224, 50);
            this.rask2_add.Name = "rask2_add";
            this.rask2_add.Size = new System.Drawing.Size(89, 25);
            this.rask2_add.TabIndex = 9;
            this.rask2_add.Text = "Додати";
            this.rask2_add.UseVisualStyleBackColor = true;
            this.rask2_add.Click += new System.EventHandler(this.rask2_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(166, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 306);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Лабораторна робота 18";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button task1_display;
        private System.Windows.Forms.Button task1_sort;
        private System.Windows.Forms.TextBox txt1index;
        private System.Windows.Forms.Button task1_b;
        private System.Windows.Forms.TextBox txt1value;
        private System.Windows.Forms.Button task1_a;
        private System.Windows.Forms.Button task1_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label task2_j;
        private System.Windows.Forms.TextBox txt2cols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2rows;
        private System.Windows.Forms.TextBox txt2value;
        private System.Windows.Forms.Button rask2_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2thisRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button task2_display3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button task2_display2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt2thisCol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button task2_display1;
        private System.Windows.Forms.Label label6;
    }
}

