namespace TUGAS_DATAGRIDVIEW
{
    public class ObjekKategori
    {
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        public string Kategori { get; set; }
        public string Jenis { get; set; }
    }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            buttonTambah = new Button();
            label1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(738, 502);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(636, 187);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = SystemColors.Info;
            buttonTambah.Font = new Font("Modern No. 20", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTambah.Location = new Point(498, 295);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(173, 34);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "TAMBAH";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 3;
            label1.Text = "Recap Data ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(729, 450);
            Controls.Add(label1);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Data";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button buttonTambah;
        private Label label1;
        private PageSetupDialog pageSetupDialog1;
    }
}