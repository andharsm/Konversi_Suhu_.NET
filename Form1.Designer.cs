namespace Tugas_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuhu = new System.Windows.Forms.TextBox();
            this.comboSuhu = new System.Windows.Forms.ComboBox();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbReamur = new System.Windows.Forms.RadioButton();
            this.btKonversi = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI SUHU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUHU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KE :";
            // 
            // txtSuhu
            // 
            this.txtSuhu.Location = new System.Drawing.Point(111, 152);
            this.txtSuhu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSuhu.Name = "txtSuhu";
            this.txtSuhu.Size = new System.Drawing.Size(114, 27);
            this.txtSuhu.TabIndex = 3;
            this.txtSuhu.TextChanged += new System.EventHandler(this.txtSuhu_TextChanged);
            // 
            // comboSuhu
            // 
            this.comboSuhu.FormattingEnabled = true;
            this.comboSuhu.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur"});
            this.comboSuhu.Location = new System.Drawing.Point(243, 152);
            this.comboSuhu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSuhu.Name = "comboSuhu";
            this.comboSuhu.Size = new System.Drawing.Size(138, 28);
            this.comboSuhu.TabIndex = 4;
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(111, 197);
            this.rbCelcius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(76, 24);
            this.rbCelcius.TabIndex = 5;
            this.rbCelcius.TabStop = true;
            this.rbCelcius.Text = "Celcius";
            this.rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(111, 231);
            this.rbFahrenheit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(98, 24);
            this.rbFahrenheit.TabIndex = 6;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbReamur
            // 
            this.rbReamur.AutoSize = true;
            this.rbReamur.Location = new System.Drawing.Point(111, 264);
            this.rbReamur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbReamur.Name = "rbReamur";
            this.rbReamur.Size = new System.Drawing.Size(81, 24);
            this.rbReamur.TabIndex = 7;
            this.rbReamur.TabStop = true;
            this.rbReamur.Text = "Reamur";
            this.rbReamur.UseVisualStyleBackColor = true;
            // 
            // btKonversi
            // 
            this.btKonversi.Location = new System.Drawing.Point(49, 309);
            this.btKonversi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btKonversi.Name = "btKonversi";
            this.btKonversi.Size = new System.Drawing.Size(333, 52);
            this.btKonversi.TabIndex = 8;
            this.btKonversi.Text = "Konversi";
            this.btKonversi.UseVisualStyleBackColor = true;
            this.btKonversi.Click += new System.EventHandler(this.btKonversi_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(243, 385);
            this.txtHasil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(138, 27);
            this.txtHasil.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasil";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(243, 440);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(138, 52);
            this.btReset.TabIndex = 11;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 600);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btKonversi);
            this.Controls.Add(this.rbReamur);
            this.Controls.Add(this.rbFahrenheit);
            this.Controls.Add(this.rbCelcius);
            this.Controls.Add(this.comboSuhu);
            this.Controls.Add(this.txtSuhu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TUGAS PRAKTIKUM 1 (20SA1089)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSuhu;
        private ComboBox comboSuhu;
        private RadioButton rbCelcius;
        private RadioButton rbFahrenheit;
        private RadioButton rbReamur;
        private Button btKonversi;
        private TextBox txtHasil;
        private Label label4;
        private Button btReset;
    }
}