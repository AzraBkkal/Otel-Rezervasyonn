namespace OtelReervasyon
{
    partial class Form2
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnREZERVASYON = new Button();
            btnMUSTERİBİLGİLERİ = new Button();
            btnFATURA = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnREZERVASYON);
            panel1.Controls.Add(btnMUSTERİBİLGİLERİ);
            panel1.Controls.Add(btnFATURA);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 613);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ekran_görüntüsü_2025_01_11_165015;
            pictureBox1.Location = new Point(12, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnREZERVASYON
            // 
            btnREZERVASYON.Location = new Point(23, 28);
            btnREZERVASYON.Name = "btnREZERVASYON";
            btnREZERVASYON.Size = new Size(183, 54);
            btnREZERVASYON.TabIndex = 0;
            btnREZERVASYON.Text = "REZERVASYON YAP";
            btnREZERVASYON.UseVisualStyleBackColor = true;
            btnREZERVASYON.Click += btnREZERVASYON_Click;
            // 
            // btnMUSTERİBİLGİLERİ
            // 
            btnMUSTERİBİLGİLERİ.Location = new Point(23, 113);
            btnMUSTERİBİLGİLERİ.Name = "btnMUSTERİBİLGİLERİ";
            btnMUSTERİBİLGİLERİ.Size = new Size(183, 54);
            btnMUSTERİBİLGİLERİ.TabIndex = 1;
            btnMUSTERİBİLGİLERİ.Text = "REZERVASYON BİLGİLERİ";
            btnMUSTERİBİLGİLERİ.UseVisualStyleBackColor = true;
            btnMUSTERİBİLGİLERİ.Click += btnMUSTERİBİLGİLERİ_Click;
            // 
            // btnFATURA
            // 
            btnFATURA.Location = new Point(23, 198);
            btnFATURA.Name = "btnFATURA";
            btnFATURA.Size = new Size(183, 54);
            btnFATURA.TabIndex = 1;
            btnFATURA.Text = "FATURA BİLGİSİ AL";
            btnFATURA.UseVisualStyleBackColor = true;
            btnFATURA.Click += btnFATURA_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(253, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(798, 524);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 613);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMUSTERİBİLGİLERİ;
        private Button btnREZERVASYON;
        private Button btnFATURA;
        private PictureBox pictureBox1;
        private ListBox listBox1;
    }
}