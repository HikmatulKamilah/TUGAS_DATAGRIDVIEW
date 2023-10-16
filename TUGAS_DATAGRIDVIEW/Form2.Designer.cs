namespace TUGAS_DATAGRIDVIEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            buttonsimpan = new Button();
            button8 = new Button();
            textNama = new TextBox();
            textDeskripsi = new TextBox();
            textKategori = new TextBox();
            textJenis = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 496);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 40);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 1;
            label1.Text = "Entri Data Peternakan";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(83, 83);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "NAMA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Location = new Point(83, 157);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "DESKRIPSI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientInactiveCaption;
            button5.Location = new Point(83, 223);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 6;
            button5.Text = "KATEGORI";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // buttonsimpan
            // 
            buttonsimpan.BackColor = SystemColors.ActiveCaption;
            buttonsimpan.Location = new Point(446, 357);
            buttonsimpan.Name = "buttonsimpan";
            buttonsimpan.Size = new Size(112, 34);
            buttonsimpan.TabIndex = 8;
            buttonsimpan.Text = "SIMPAN";
            buttonsimpan.UseVisualStyleBackColor = false;
            buttonsimpan.Click += buttonsimpan_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientInactiveCaption;
            button8.Location = new Point(83, 302);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 9;
            button8.Text = "JENIS";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textNama
            // 
            textNama.BackColor = SystemColors.Info;
            textNama.Location = new Point(228, 86);
            textNama.Name = "textNama";
            textNama.Size = new Size(350, 31);
            textNama.TabIndex = 10;
            // 
            // textDeskripsi
            // 
            textDeskripsi.BackColor = SystemColors.Info;
            textDeskripsi.Location = new Point(228, 160);
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(350, 31);
            textDeskripsi.TabIndex = 11;
            // 
            // textKategori
            // 
            textKategori.BackColor = SystemColors.Info;
            textKategori.Location = new Point(228, 236);
            textKategori.Name = "textKategori";
            textKategori.Size = new Size(350, 31);
            textKategori.TabIndex = 12;
            // 
            // textJenis
            // 
            textJenis.BackColor = SystemColors.Info;
            textJenis.Location = new Point(228, 305);
            textJenis.Name = "textJenis";
            textJenis.Size = new Size(350, 31);
            textJenis.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(textJenis);
            Controls.Add(textKategori);
            Controls.Add(textDeskripsi);
            Controls.Add(textNama);
            Controls.Add(button8);
            Controls.Add(buttonsimpan);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button buttonsimpan;
        private Button button8;
        private TextBox textNama;
        private TextBox textDeskripsi;
        private TextBox textKategori;
        private TextBox textJenis;
    }
}