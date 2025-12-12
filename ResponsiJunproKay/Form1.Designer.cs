namespace ResponsiJunproKay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.gbDataDeveloper = new System.Windows.Forms.GroupBox();
            this.lblNamaDeveloper = new System.Windows.Forms.Label();
            this.lblPilihProyek = new System.Windows.Forms.Label();
            this.lblStatusKontrak = new System.Windows.Forms.Label();
            this.tbNamaDeveloper = new System.Windows.Forms.TextBox();
            this.cbPilihProyek = new System.Windows.Forms.ComboBox();
            this.cbStatusKontrak = new System.Windows.Forms.ComboBox();
            this.gbDataKinerja = new System.Windows.Forms.GroupBox();
            this.lblFiturSelesai = new System.Windows.Forms.Label();
            this.lblJumlahBug = new System.Windows.Forms.Label();
            this.tbFiturSelesai = new System.Windows.Forms.TextBox();
            this.tbJumlahBug = new System.Windows.Forms.TextBox();
            this.lblKetFitur = new System.Windows.Forms.Label();
            this.lblKetBug = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDaftarPerformaTim = new System.Windows.Forms.GroupBox();
            this.dgvDaftarPerformaTim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDataDeveloper.SuspendLayout();
            this.gbDataKinerja.SuspendLayout();
            this.gbDaftarPerformaTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPerformaTim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResponsiJunproKay.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(180, 50);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(266, 20);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "APLIKASI RESPONSI  JUNPRO";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(181, 79);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(262, 18);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Developer Team Performance Tracker";
            // 
            // gbDataDeveloper
            // 
            this.gbDataDeveloper.Controls.Add(this.cbStatusKontrak);
            this.gbDataDeveloper.Controls.Add(this.cbPilihProyek);
            this.gbDataDeveloper.Controls.Add(this.tbNamaDeveloper);
            this.gbDataDeveloper.Controls.Add(this.lblStatusKontrak);
            this.gbDataDeveloper.Controls.Add(this.lblPilihProyek);
            this.gbDataDeveloper.Controls.Add(this.lblNamaDeveloper);
            this.gbDataDeveloper.Location = new System.Drawing.Point(39, 146);
            this.gbDataDeveloper.Name = "gbDataDeveloper";
            this.gbDataDeveloper.Size = new System.Drawing.Size(451, 120);
            this.gbDataDeveloper.TabIndex = 3;
            this.gbDataDeveloper.TabStop = false;
            this.gbDataDeveloper.Text = "DATA DEVELOPER";
            // 
            // lblNamaDeveloper
            // 
            this.lblNamaDeveloper.AutoSize = true;
            this.lblNamaDeveloper.Location = new System.Drawing.Point(7, 29);
            this.lblNamaDeveloper.Name = "lblNamaDeveloper";
            this.lblNamaDeveloper.Size = new System.Drawing.Size(90, 13);
            this.lblNamaDeveloper.TabIndex = 0;
            this.lblNamaDeveloper.Text = "Nama Developer:";
            // 
            // lblPilihProyek
            // 
            this.lblPilihProyek.AutoSize = true;
            this.lblPilihProyek.Location = new System.Drawing.Point(7, 59);
            this.lblPilihProyek.Name = "lblPilihProyek";
            this.lblPilihProyek.Size = new System.Drawing.Size(65, 13);
            this.lblPilihProyek.TabIndex = 1;
            this.lblPilihProyek.Text = "Pilih Proyek:";
            // 
            // lblStatusKontrak
            // 
            this.lblStatusKontrak.AutoSize = true;
            this.lblStatusKontrak.Location = new System.Drawing.Point(7, 87);
            this.lblStatusKontrak.Name = "lblStatusKontrak";
            this.lblStatusKontrak.Size = new System.Drawing.Size(80, 13);
            this.lblStatusKontrak.TabIndex = 2;
            this.lblStatusKontrak.Text = "Status Kontrak:\r\n";
            // 
            // tbNamaDeveloper
            // 
            this.tbNamaDeveloper.Location = new System.Drawing.Point(124, 29);
            this.tbNamaDeveloper.Name = "tbNamaDeveloper";
            this.tbNamaDeveloper.Size = new System.Drawing.Size(123, 20);
            this.tbNamaDeveloper.TabIndex = 3;
            // 
            // cbPilihProyek
            // 
            this.cbPilihProyek.FormattingEnabled = true;
            this.cbPilihProyek.Location = new System.Drawing.Point(124, 56);
            this.cbPilihProyek.Name = "cbPilihProyek";
            this.cbPilihProyek.Size = new System.Drawing.Size(123, 21);
            this.cbPilihProyek.TabIndex = 4;
            // 
            // cbStatusKontrak
            // 
            this.cbStatusKontrak.FormattingEnabled = true;
            this.cbStatusKontrak.Items.AddRange(new object[] {
            "Freelance",
            "Full Time"});
            this.cbStatusKontrak.Location = new System.Drawing.Point(124, 84);
            this.cbStatusKontrak.Name = "cbStatusKontrak";
            this.cbStatusKontrak.Size = new System.Drawing.Size(123, 21);
            this.cbStatusKontrak.TabIndex = 5;
            // 
            // gbDataKinerja
            // 
            this.gbDataKinerja.Controls.Add(this.lblKetBug);
            this.gbDataKinerja.Controls.Add(this.lblKetFitur);
            this.gbDataKinerja.Controls.Add(this.tbJumlahBug);
            this.gbDataKinerja.Controls.Add(this.tbFiturSelesai);
            this.gbDataKinerja.Controls.Add(this.lblJumlahBug);
            this.gbDataKinerja.Controls.Add(this.lblFiturSelesai);
            this.gbDataKinerja.Location = new System.Drawing.Point(37, 282);
            this.gbDataKinerja.Name = "gbDataKinerja";
            this.gbDataKinerja.Size = new System.Drawing.Size(453, 88);
            this.gbDataKinerja.TabIndex = 4;
            this.gbDataKinerja.TabStop = false;
            this.gbDataKinerja.Text = "DATA KINERJA";
            // 
            // lblFiturSelesai
            // 
            this.lblFiturSelesai.AutoSize = true;
            this.lblFiturSelesai.Location = new System.Drawing.Point(9, 30);
            this.lblFiturSelesai.Name = "lblFiturSelesai";
            this.lblFiturSelesai.Size = new System.Drawing.Size(67, 13);
            this.lblFiturSelesai.TabIndex = 0;
            this.lblFiturSelesai.Text = "Fitur Selesai:";
            // 
            // lblJumlahBug
            // 
            this.lblJumlahBug.AutoSize = true;
            this.lblJumlahBug.Location = new System.Drawing.Point(9, 57);
            this.lblJumlahBug.Name = "lblJumlahBug";
            this.lblJumlahBug.Size = new System.Drawing.Size(65, 13);
            this.lblJumlahBug.TabIndex = 1;
            this.lblJumlahBug.Text = "Jumlah Bug:";
            // 
            // tbFiturSelesai
            // 
            this.tbFiturSelesai.Location = new System.Drawing.Point(126, 27);
            this.tbFiturSelesai.Name = "tbFiturSelesai";
            this.tbFiturSelesai.Size = new System.Drawing.Size(41, 20);
            this.tbFiturSelesai.TabIndex = 2;
            // 
            // tbJumlahBug
            // 
            this.tbJumlahBug.Location = new System.Drawing.Point(126, 54);
            this.tbJumlahBug.Name = "tbJumlahBug";
            this.tbJumlahBug.Size = new System.Drawing.Size(41, 20);
            this.tbJumlahBug.TabIndex = 3;
            // 
            // lblKetFitur
            // 
            this.lblKetFitur.AutoSize = true;
            this.lblKetFitur.Location = new System.Drawing.Point(177, 29);
            this.lblKetFitur.Name = "lblKetFitur";
            this.lblKetFitur.Size = new System.Drawing.Size(144, 13);
            this.lblKetFitur.TabIndex = 4;
            this.lblKetFitur.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // lblKetBug
            // 
            this.lblKetBug.AutoSize = true;
            this.lblKetBug.Location = new System.Drawing.Point(177, 54);
            this.lblKetBug.Name = "lblKetBug";
            this.lblKetBug.Size = new System.Drawing.Size(145, 13);
            this.lblKetBug.TabIndex = 5;
            this.lblKetBug.Text = "(Jumlah bug yang ditemukan)";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(37, 386);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(112, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(214, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbDaftarPerformaTim
            // 
            this.gbDaftarPerformaTim.Controls.Add(this.dgvDaftarPerformaTim);
            this.gbDaftarPerformaTim.Location = new System.Drawing.Point(37, 437);
            this.gbDaftarPerformaTim.Name = "gbDaftarPerformaTim";
            this.gbDaftarPerformaTim.Size = new System.Drawing.Size(453, 142);
            this.gbDaftarPerformaTim.TabIndex = 9;
            this.gbDaftarPerformaTim.TabStop = false;
            this.gbDaftarPerformaTim.Text = "DAFTAR PERFORMA TIM";
            // 
            // dgvDaftarPerformaTim
            // 
            this.dgvDaftarPerformaTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarPerformaTim.Location = new System.Drawing.Point(0, 20);
            this.dgvDaftarPerformaTim.Name = "dgvDaftarPerformaTim";
            this.dgvDaftarPerformaTim.Size = new System.Drawing.Size(453, 122);
            this.dgvDaftarPerformaTim.TabIndex = 0;
            this.dgvDaftarPerformaTim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftarPerformaTim_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 622);
            this.Controls.Add(this.gbDaftarPerformaTim);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gbDataKinerja);
            this.Controls.Add(this.gbDataDeveloper);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDataDeveloper.ResumeLayout(false);
            this.gbDataDeveloper.PerformLayout();
            this.gbDataKinerja.ResumeLayout(false);
            this.gbDataKinerja.PerformLayout();
            this.gbDaftarPerformaTim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarPerformaTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox gbDataDeveloper;
        private System.Windows.Forms.TextBox tbNamaDeveloper;
        private System.Windows.Forms.Label lblStatusKontrak;
        private System.Windows.Forms.Label lblPilihProyek;
        private System.Windows.Forms.Label lblNamaDeveloper;
        private System.Windows.Forms.ComboBox cbStatusKontrak;
        private System.Windows.Forms.ComboBox cbPilihProyek;
        private System.Windows.Forms.GroupBox gbDataKinerja;
        private System.Windows.Forms.Label lblKetBug;
        private System.Windows.Forms.Label lblKetFitur;
        private System.Windows.Forms.TextBox tbJumlahBug;
        private System.Windows.Forms.TextBox tbFiturSelesai;
        private System.Windows.Forms.Label lblJumlahBug;
        private System.Windows.Forms.Label lblFiturSelesai;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbDaftarPerformaTim;
        private System.Windows.Forms.DataGridView dgvDaftarPerformaTim;
    }
}

