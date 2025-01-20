namespace OtelReervasyon
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateGİRİS = new DateTimePicker();
            dateCIKIS = new DateTimePicker();
            comboODA = new ComboBox();
            txtAD = new TextBox();
            txtTEL = new TextBox();
            btnREZERVASYON = new Button();
            btnANAMENU = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(79, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "MÜŞTERİ ADI-SOYADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(81, 73);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 1;
            label2.Text = "MÜŞTERİ TELEFON NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(147, 123);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "GİRİŞ TARİHİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Location = new Point(142, 168);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "ÇIKIŞ TARİHİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Location = new Point(149, 216);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 4;
            label5.Text = "ODA SEÇİMİ";
            // 
            // dateGİRİS
            // 
            dateGİRİS.Location = new Point(262, 118);
            dateGİRİS.Name = "dateGİRİS";
            dateGİRİS.Size = new Size(250, 27);
            dateGİRİS.TabIndex = 5;
            // 
            // dateCIKIS
            // 
            dateCIKIS.Location = new Point(262, 163);
            dateCIKIS.Name = "dateCIKIS";
            dateCIKIS.Size = new Size(250, 27);
            dateCIKIS.TabIndex = 6;
            // 
            // comboODA
            // 
            comboODA.FormattingEnabled = true;
            comboODA.Items.AddRange(new object[] { "tek kişilik oda ", "çift kişilik oda", "suit oda", "balayı odası" });
            comboODA.Location = new Point(262, 213);
            comboODA.Name = "comboODA";
            comboODA.Size = new Size(151, 28);
            comboODA.TabIndex = 7;
            comboODA.Text = "seçiniz";
            // 
            // txtAD
            // 
            txtAD.Location = new Point(262, 22);
            txtAD.Name = "txtAD";
            txtAD.Size = new Size(125, 27);
            txtAD.TabIndex = 8;
            // 
            // txtTEL
            // 
            txtTEL.Location = new Point(262, 66);
            txtTEL.Name = "txtTEL";
            txtTEL.Size = new Size(130, 27);
            txtTEL.TabIndex = 9;
            // 
            // btnREZERVASYON
            // 
            btnREZERVASYON.Location = new Point(149, 269);
            btnREZERVASYON.Name = "btnREZERVASYON";
            btnREZERVASYON.Size = new Size(158, 82);
            btnREZERVASYON.TabIndex = 10;
            btnREZERVASYON.Text = "REZERVASYON YAP";
            btnREZERVASYON.UseVisualStyleBackColor = true;
            btnREZERVASYON.Click += btnREZERVASYON_Click;
            // 
            // btnANAMENU
            // 
            btnANAMENU.Location = new Point(348, 269);
            btnANAMENU.Name = "btnANAMENU";
            btnANAMENU.Size = new Size(114, 82);
            btnANAMENU.TabIndex = 11;
            btnANAMENU.Text = "ANA MENÜYE DÖN";
            btnANAMENU.UseVisualStyleBackColor = true;
            btnANAMENU.Click += btnANAMENU_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnANAMENU);
            Controls.Add(btnREZERVASYON);
            Controls.Add(txtTEL);
            Controls.Add(txtAD);
            Controls.Add(comboODA);
            Controls.Add(dateCIKIS);
            Controls.Add(dateGİRİS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateGİRİS;
        private DateTimePicker dateCIKIS;
        private ComboBox comboODA;
        private TextBox txtAD;
        private TextBox txtTEL;
        private Button btnREZERVASYON;
        private Button btnANAMENU;
    }
}