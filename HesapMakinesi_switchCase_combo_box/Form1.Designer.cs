namespace HesapMakinesi_switchCase_combo_box
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
            txt_ilk = new TextBox();
            txt_iki = new TextBox();
            cmbİslem = new ComboBox();
            btnHesapla = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSonuc = new Label();
            label2 = new Label();
            lblGecersiz = new Label();
            SuspendLayout();
            // 
            // txt_ilk
            // 
            txt_ilk.Location = new Point(715, 75);
            txt_ilk.Margin = new Padding(5, 5, 5, 5);
            txt_ilk.Name = "txt_ilk";
            txt_ilk.Size = new Size(734, 61);
            txt_ilk.TabIndex = 0;
            // 
            // txt_iki
            // 
            txt_iki.Location = new Point(715, 224);
            txt_iki.Margin = new Padding(5, 5, 5, 5);
            txt_iki.Name = "txt_iki";
            txt_iki.Size = new Size(734, 61);
            txt_iki.TabIndex = 1;
            // 
            // cmbİslem
            // 
            cmbİslem.FormattingEnabled = true;
            cmbİslem.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbİslem.Location = new Point(715, 379);
            cmbİslem.Margin = new Padding(5, 5, 5, 5);
            cmbİslem.Name = "cmbİslem";
            cmbİslem.Size = new Size(734, 62);
            cmbİslem.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(715, 527);
            btnHesapla.Margin = new Padding(5, 5, 5, 5);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(254, 78);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(253, 791);
            label1.Name = "label1";
            label1.Size = new Size(203, 62);
            label1.TabIndex = 4;
            label1.Text = "SONUÇ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(253, 224);
            label3.Name = "label3";
            label3.Size = new Size(276, 62);
            label3.TabIndex = 6;
            label3.Text = "İKİNCİ SAYI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F);
            label4.Location = new Point(253, 387);
            label4.Name = "label4";
            label4.Size = new Size(172, 62);
            label4.TabIndex = 7;
            label4.Text = "İŞLEM :";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(715, 791);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 54);
            lblSonuc.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(253, 75);
            label2.Name = "label2";
            label2.Size = new Size(303, 62);
            label2.TabIndex = 9;
            label2.Text = "BİRİNCİ SAYI :";
            // 
            // lblGecersiz
            // 
            lblGecersiz.AutoSize = true;
            lblGecersiz.Location = new Point(798, 953);
            lblGecersiz.Name = "lblGecersiz";
            lblGecersiz.Size = new Size(0, 54);
            lblGecersiz.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1913, 1081);
            Controls.Add(lblGecersiz);
            Controls.Add(label2);
            Controls.Add(lblSonuc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnHesapla);
            Controls.Add(cmbİslem);
            Controls.Add(txt_iki);
            Controls.Add(txt_ilk);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ilk;
        private TextBox txt_iki;
        private ComboBox cmbİslem;
        private Button btnHesapla;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblSonuc;
        private Label label2;
        private Label lblGecersiz;
    }
}
