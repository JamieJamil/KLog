namespace KørselsLog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OkBtn1 = new System.Windows.Forms.Button();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Dato1 = new System.Windows.Forms.Label();
            this.Plade1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PladeTB1 = new System.Windows.Forms.TextBox();
            this.DatoTB1 = new System.Windows.Forms.TextBox();
            this.NavnTB1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OkBtn2 = new System.Windows.Forms.Button();
            this.NavnTB2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PladeTB2 = new System.Windows.Forms.TextBox();
            this.DatoTB2 = new System.Windows.Forms.TextBox();
            this.CancelBtn2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OkBtn3 = new System.Windows.Forms.Button();
            this.CancelBtn3 = new System.Windows.Forms.Button();
            this.NavnTB3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OkBtn4 = new System.Windows.Forms.Button();
            this.CancelBtn4 = new System.Windows.Forms.Button();
            this.NavnTB4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OpgaveTB4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PladeTB4 = new System.Windows.Forms.TextBox();
            this.DatoTB4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OkBtn1);
            this.groupBox1.Controls.Add(this.CancelBtn1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Dato1);
            this.groupBox1.Controls.Add(this.Plade1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PladeTB1);
            this.groupBox1.Controls.Add(this.DatoTB1);
            this.groupBox1.Controls.Add(this.NavnTB1);
            this.groupBox1.Location = new System.Drawing.Point(25, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // OkBtn1
            // 
            this.OkBtn1.Location = new System.Drawing.Point(121, 167);
            this.OkBtn1.Name = "OkBtn1";
            this.OkBtn1.Size = new System.Drawing.Size(52, 23);
            this.OkBtn1.TabIndex = 13;
            this.OkBtn1.Text = "Ok";
            this.OkBtn1.UseVisualStyleBackColor = true;
            this.OkBtn1.Click += new System.EventHandler(this.OkBtn1_Click);
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(6, 167);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn1.TabIndex = 12;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Opret Stamdata:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Dato1
            // 
            this.Dato1.AutoSize = true;
            this.Dato1.Location = new System.Drawing.Point(6, 82);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(35, 15);
            this.Dato1.TabIndex = 7;
            this.Dato1.Text = "Dato:";
            // 
            // Plade1
            // 
            this.Plade1.AutoSize = true;
            this.Plade1.Location = new System.Drawing.Point(6, 115);
            this.Plade1.Name = "Plade1";
            this.Plade1.Size = new System.Drawing.Size(58, 15);
            this.Plade1.TabIndex = 6;
            this.Plade1.Text = "Nr. Plade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Navn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PladeTB1
            // 
            this.PladeTB1.Location = new System.Drawing.Point(70, 111);
            this.PladeTB1.Name = "PladeTB1";
            this.PladeTB1.Size = new System.Drawing.Size(103, 23);
            this.PladeTB1.TabIndex = 4;
            this.PladeTB1.TextChanged += new System.EventHandler(this.PladeTB1_TextChanged);
            // 
            // DatoTB1
            // 
            this.DatoTB1.Location = new System.Drawing.Point(70, 79);
            this.DatoTB1.Name = "DatoTB1";
            this.DatoTB1.Size = new System.Drawing.Size(103, 23);
            this.DatoTB1.TabIndex = 3;
            // 
            // NavnTB1
            // 
            this.NavnTB1.Location = new System.Drawing.Point(70, 47);
            this.NavnTB1.Name = "NavnTB1";
            this.NavnTB1.Size = new System.Drawing.Size(103, 23);
            this.NavnTB1.TabIndex = 2;
            this.NavnTB1.TextChanged += new System.EventHandler(this.NavnTB1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OkBtn2);
            this.groupBox2.Controls.Add(this.NavnTB2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PladeTB2);
            this.groupBox2.Controls.Add(this.DatoTB2);
            this.groupBox2.Controls.Add(this.CancelBtn2);
            this.groupBox2.Location = new System.Drawing.Point(253, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // OkBtn2
            // 
            this.OkBtn2.Location = new System.Drawing.Point(121, 167);
            this.OkBtn2.Name = "OkBtn2";
            this.OkBtn2.Size = new System.Drawing.Size(52, 23);
            this.OkBtn2.TabIndex = 12;
            this.OkBtn2.Text = "Ok";
            this.OkBtn2.UseVisualStyleBackColor = true;
            this.OkBtn2.Click += new System.EventHandler(this.OkBtn2_Click);
            // 
            // NavnTB2
            // 
            this.NavnTB2.FormattingEnabled = true;
            this.NavnTB2.Location = new System.Drawing.Point(70, 47);
            this.NavnTB2.Name = "NavnTB2";
            this.NavnTB2.Size = new System.Drawing.Size(103, 23);
            this.NavnTB2.TabIndex = 11;
            this.NavnTB2.SelectedIndexChanged += new System.EventHandler(this.NavnTB2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Rediger Stamdata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nr. Plade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Navn:";
            // 
            // PladeTB2
            // 
            this.PladeTB2.Location = new System.Drawing.Point(70, 111);
            this.PladeTB2.Name = "PladeTB2";
            this.PladeTB2.Size = new System.Drawing.Size(103, 23);
            this.PladeTB2.TabIndex = 4;
            // 
            // DatoTB2
            // 
            this.DatoTB2.Location = new System.Drawing.Point(70, 79);
            this.DatoTB2.Name = "DatoTB2";
            this.DatoTB2.Size = new System.Drawing.Size(103, 23);
            this.DatoTB2.TabIndex = 3;
            // 
            // CancelBtn2
            // 
            this.CancelBtn2.Location = new System.Drawing.Point(6, 167);
            this.CancelBtn2.Name = "CancelBtn2";
            this.CancelBtn2.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn2.TabIndex = 0;
            this.CancelBtn2.Text = "Cancel";
            this.CancelBtn2.UseVisualStyleBackColor = true;
            this.CancelBtn2.Click += new System.EventHandler(this.CancelBtn2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OkBtn3);
            this.groupBox3.Controls.Add(this.CancelBtn3);
            this.groupBox3.Controls.Add(this.NavnTB3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(478, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // OkBtn3
            // 
            this.OkBtn3.Location = new System.Drawing.Point(121, 101);
            this.OkBtn3.Name = "OkBtn3";
            this.OkBtn3.Size = new System.Drawing.Size(52, 23);
            this.OkBtn3.TabIndex = 13;
            this.OkBtn3.Text = "Ok";
            this.OkBtn3.UseVisualStyleBackColor = true;
            this.OkBtn3.Click += new System.EventHandler(this.OkBtn3_Click);
            // 
            // CancelBtn3
            // 
            this.CancelBtn3.Location = new System.Drawing.Point(6, 99);
            this.CancelBtn3.Name = "CancelBtn3";
            this.CancelBtn3.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn3.TabIndex = 13;
            this.CancelBtn3.Text = "Cancel";
            this.CancelBtn3.UseVisualStyleBackColor = true;
            this.CancelBtn3.Click += new System.EventHandler(this.CancelBtn3_Click);
            // 
            // NavnTB3
            // 
            this.NavnTB3.FormattingEnabled = true;
            this.NavnTB3.Location = new System.Drawing.Point(70, 47);
            this.NavnTB3.Name = "NavnTB3";
            this.NavnTB3.Size = new System.Drawing.Size(103, 23);
            this.NavnTB3.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Slet Stamdata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Navn:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OkBtn4);
            this.groupBox4.Controls.Add(this.CancelBtn4);
            this.groupBox4.Controls.Add(this.NavnTB4);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.OpgaveTB4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.PladeTB4);
            this.groupBox4.Controls.Add(this.DatoTB4);
            this.groupBox4.Location = new System.Drawing.Point(870, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 209);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // OkBtn4
            // 
            this.OkBtn4.Location = new System.Drawing.Point(121, 180);
            this.OkBtn4.Name = "OkBtn4";
            this.OkBtn4.Size = new System.Drawing.Size(52, 23);
            this.OkBtn4.TabIndex = 14;
            this.OkBtn4.Text = "Ok";
            this.OkBtn4.UseVisualStyleBackColor = true;
            this.OkBtn4.Click += new System.EventHandler(this.OkBtn4_Click);
            // 
            // CancelBtn4
            // 
            this.CancelBtn4.Location = new System.Drawing.Point(6, 180);
            this.CancelBtn4.Name = "CancelBtn4";
            this.CancelBtn4.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn4.TabIndex = 14;
            this.CancelBtn4.Text = "Cancel";
            this.CancelBtn4.UseVisualStyleBackColor = true;
            this.CancelBtn4.Click += new System.EventHandler(this.CancelBtn4_Click);
            // 
            // NavnTB4
            // 
            this.NavnTB4.FormattingEnabled = true;
            this.NavnTB4.Location = new System.Drawing.Point(70, 42);
            this.NavnTB4.Name = "NavnTB4";
            this.NavnTB4.Size = new System.Drawing.Size(103, 23);
            this.NavnTB4.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Opret Kørsels Log:";
            // 
            // OpgaveTB4
            // 
            this.OpgaveTB4.Location = new System.Drawing.Point(70, 138);
            this.OpgaveTB4.Name = "OpgaveTB4";
            this.OpgaveTB4.Size = new System.Drawing.Size(103, 23);
            this.OpgaveTB4.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Opgave:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nr. Plade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Navn:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PladeTB4
            // 
            this.PladeTB4.Location = new System.Drawing.Point(70, 107);
            this.PladeTB4.Name = "PladeTB4";
            this.PladeTB4.Size = new System.Drawing.Size(103, 23);
            this.PladeTB4.TabIndex = 4;
            // 
            // DatoTB4
            // 
            this.DatoTB4.Location = new System.Drawing.Point(70, 74);
            this.DatoTB4.Name = "DatoTB4";
            this.DatoTB4.Size = new System.Drawing.Size(103, 23);
            this.DatoTB4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(425, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(90, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Personale Data:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(844, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "Kørsels Log Registrering:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 501);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox PladeTB1;
        private TextBox DatoTB1;
        private TextBox NavnTB1;
        private Label Dato1;
        private Label Plade1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PladeTB2;
        private TextBox DatoTB2;
        private Button CancelBtn2;
        private GroupBox groupBox3;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox OpgaveTB4;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox PladeTB4;
        private TextBox DatoTB4;
        private Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView1;
        private Label label14;
        private Label label15;
        private ComboBox NavnTB2;
        private ComboBox NavnTB3;
        private ComboBox NavnTB4;
        private Button CancelBtn1;
        private Button CancelBtn3;
        private Button CancelBtn4;
        private Button OkBtn1;
        private Button OkBtn2;
        private Button OkBtn3;
        private Button OkBtn4;
    }
}