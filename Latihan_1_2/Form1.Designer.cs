namespace Latihan_1_2
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.range1 = new System.Windows.Forms.Label();
            this.range2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(42, 19);
            this.vScrollBar1.Maximum = 49;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 130);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(231, 19);
            this.vScrollBar2.Maximum = 49;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 130);
            this.vScrollBar2.TabIndex = 1;
            this.vScrollBar2.Value = 40;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(148, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "40";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Thistle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(42, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Thistle;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(148, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // range1
            // 
            this.range1.AutoSize = true;
            this.range1.Location = new System.Drawing.Point(39, 166);
            this.range1.Name = "range1";
            this.range1.Size = new System.Drawing.Size(65, 13);
            this.range1.TabIndex = 7;
            this.range1.Text = "Range (Min)";
            // 
            // range2
            // 
            this.range2.AutoSize = true;
            this.range2.Location = new System.Drawing.Point(145, 166);
            this.range2.Name = "range2";
            this.range2.Size = new System.Drawing.Size(68, 13);
            this.range2.TabIndex = 8;
            this.range2.Text = "Range (Max)";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Location = new System.Drawing.Point(39, 205);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(56, 13);
            this.date1.TabIndex = 9;
            this.date1.Text = "Date (Min)";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Location = new System.Drawing.Point(145, 205);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(59, 13);
            this.date2.TabIndex = 10;
            this.date2.Text = "Date (Max)";
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.Location = new System.Drawing.Point(44, 6);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(13, 13);
            this.min1.TabIndex = 11;
            this.min1.Text = "0";
            // 
            // min2
            // 
            this.min2.AutoSize = true;
            this.min2.Location = new System.Drawing.Point(233, 6);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(13, 13);
            this.min2.TabIndex = 12;
            this.min2.Text = "0";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.Location = new System.Drawing.Point(43, 149);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(19, 13);
            this.max1.TabIndex = 13;
            this.max1.Text = "40";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.Location = new System.Drawing.Point(232, 149);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(19, 13);
            this.max2.TabIndex = 14;
            this.max2.Text = "40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.range2);
            this.Controls.Add(this.range1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Latihan_1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label range1;
        private System.Windows.Forms.Label range2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label max2;
    }
}

