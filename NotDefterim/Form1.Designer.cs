namespace NotDefterim
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
            con.Close();
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
            this.txtBaslık = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstBasliklar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.pnlDuzenle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBaslık
            // 
            this.txtBaslık.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaslık.Location = new System.Drawing.Point(2, 23);
            this.txtBaslık.Name = "txtBaslık";
            this.txtBaslık.Size = new System.Drawing.Size(728, 27);
            this.txtBaslık.TabIndex = 0;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYeni.Location = new System.Drawing.Point(22, 87);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(146, 50);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKaydet.Location = new System.Drawing.Point(6, 493);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 61);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(404, 493);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 61);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstBasliklar
            // 
            this.lstBasliklar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBasliklar.DisplayMember = "Baslik";
            this.lstBasliklar.FormattingEnabled = true;
            this.lstBasliklar.ItemHeight = 20;
            this.lstBasliklar.Location = new System.Drawing.Point(12, 151);
            this.lstBasliklar.Name = "lstBasliklar";
            this.lstBasliklar.Size = new System.Drawing.Size(193, 504);
            this.lstBasliklar.TabIndex = 5;
            this.lstBasliklar.SelectedIndexChanged += new System.EventHandler(this.lstBasliklar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BAŞLIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "İÇERİK";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcerik.Location = new System.Drawing.Point(5, 81);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(725, 402);
            this.txtIcerik.TabIndex = 8;
            // 
            // pnlDuzenle
            // 
            this.pnlDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDuzenle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlDuzenle.Controls.Add(this.label1);
            this.pnlDuzenle.Controls.Add(this.txtIcerik);
            this.pnlDuzenle.Controls.Add(this.txtBaslık);
            this.pnlDuzenle.Controls.Add(this.label2);
            this.pnlDuzenle.Controls.Add(this.btnKaydet);
            this.pnlDuzenle.Controls.Add(this.btnSil);
            this.pnlDuzenle.Location = new System.Drawing.Point(215, 87);
            this.pnlDuzenle.Name = "pnlDuzenle";
            this.pnlDuzenle.Size = new System.Drawing.Size(733, 568);
            this.pnlDuzenle.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(969, 59);
            this.label3.TabIndex = 10;
            this.label3.Text = "Not Defterim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(969, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlDuzenle);
            this.Controls.Add(this.lstBasliklar);
            this.Controls.Add(this.btnYeni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Defterim";
            this.pnlDuzenle.ResumeLayout(false);
            this.pnlDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtBaslık;
        private Button btnYeni;
        private Button btnKaydet;
        private Button btnSil;
        private ListBox lstBasliklar;
        private Label label1;
        private Label label2;
        private TextBox txtIcerik;
        private Panel pnlDuzenle;
        private Label label3;
    }
}