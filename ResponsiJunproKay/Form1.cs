using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ResponsiJunproKay
{
    public partial class Form1 : Form
    {
        private DeveloperRepository repo;
        private Developer selectedDeveloper;
        public Form1()
        {
            InitializeComponent();
            repo = new DeveloperRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilData();
        }
        private void TampilData()
        {
            dgvDaftarPerformaTim.DataSource = repo.LoadData();
            dgvDaftarPerformaTim.AllowUserToAddRows = false;

            if (dgvDaftarPerformaTim.Columns.Count > 0)
            {
                dgvDaftarPerformaTim.Columns["id_dev"].HeaderText = "ID Developer";
                dgvDaftarPerformaTim.Columns["nama"].HeaderText = "Nama Developer";
                dgvDaftarPerformaTim.Columns["status_kontrak"].HeaderText = "Status Kontrak";
                dgvDaftarPerformaTim.Columns["fitur_selesai"].HeaderText = "Fitur Selesai";
                dgvDaftarPerformaTim.Columns["jumlah_bug"].HeaderText = "Jumlah Bug";
                dgvDaftarPerformaTim.Columns["id_proyek"].HeaderText = "ID Proyek";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbNamaDeveloper.Text))
                {
                    MessageBox.Show("Nama Developer tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Developer d = new Developer();
                d.NamaDeveloper = tbNamaDeveloper.Text;
                d.StatusKontrak = cbStatusKontrak.Text;
                int IdProyekDipilih = 0;
                switch (cbPilihProyek.Text)
                {
                    case "Web Company Profile":
                        IdProyekDipilih = 1;
                        break;
                    case "Sistem Parkir QR":
                        IdProyekDipilih = 2;
                        break;
                    case "IoT Agriculture App":
                        IdProyekDipilih = 3;
                        break;
                    case "E-Commerce Startup":
                        IdProyekDipilih = 4;
                        break;
                    case "AI Fraud Detection":
                        IdProyekDipilih = 5;
                        break;
                    default:
                        MessageBox.Show("Pilih proyek yang valid!", "Peringatan");
                        return;
                }
                d.IdProyek = IdProyekDipilih;

                repo.AddDeveloper(d);
                MessageBox.Show("Data developer berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            tbNamaDeveloper.Clear();
            cbStatusKontrak.SelectedIndex = -1;
            cbPilihProyek.SelectedIndex = -1;
            selectedDeveloper = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDeveloper == null)
            {
                MessageBox.Show("Pilih developer yang akan diupdate dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                selectedDeveloper.NamaDeveloper = tbNamaDeveloper.Text;
                selectedDeveloper.StatusKontrak = cbStatusKontrak.Text;
                int IdProyekBaru = 0;
                switch (cbPilihProyek.Text)
                {
                    case "Web Company Profile":
                        IdProyekBaru = 1;
                        break;
                    case "Sistem Parkir QR":
                        IdProyekBaru = 2;
                        break;
                    case "IoT Agriculture App":
                        IdProyekBaru = 3;
                        break;
                    case "E-Commerce Startup":
                        IdProyekBaru = 4;
                        break;
                    case "AI Fraud Detection":
                        IdProyekBaru = 5;
                        break;
                    default:
                        MessageBox.Show("Pilih proyek yang valid!", "Peringatan");
                        return;
                }
                selectedDeveloper.IdProyek = IdProyekBaru;

                repo.EditDeveloper(selectedDeveloper);
                MessageBox.Show("Data developer berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDeveloper == null)
            {
                MessageBox.Show("Pilih developer yang akan dihapus dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus developer ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.DeleteDeveloper(selectedDeveloper.IdDev);
                MessageBox.Show("Data developer berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearForm();
            }
        }

        private void dgvDaftarPerformaTim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDaftarPerformaTim.Rows[e.RowIndex];
                selectedDeveloper = new Developer();
                selectedDeveloper.IdDev = row.Cells["id_dev"].Value.ToString();
                selectedDeveloper.NamaDeveloper = row.Cells["nama"].Value.ToString();
                selectedDeveloper.StatusKontrak = row.Cells["status_kontrak"].Value.ToString();
                selectedDeveloper.FiturSelesai = Convert.ToInt32(row.Cells["fitur_selesai"].Value);
                selectedDeveloper.JumlahBug = Convert.ToInt32(row.Cells["jumlah_bug"].Value);
                selectedDeveloper.IdProyek = Convert.ToInt32(row.Cells["id_proyek"].Value);
                tbNamaDeveloper.Text = selectedDeveloper.NamaDeveloper;
                cbStatusKontrak.Text = selectedDeveloper.StatusKontrak;
                switch (selectedDeveloper.IdProyek)
                {
                    case 1:
                        cbPilihProyek.Text = "Web Company Profile";
                        break;
                    case 2:
                        cbPilihProyek.Text = "Sistem Parkir QR";
                        break;
                    case 3:
                        cbPilihProyek.Text = "IoT Agriculture App";
                        break;
                    case 4:
                        cbPilihProyek.Text = "E-Commerce Startup";
                        break;
                    case 5:
                        cbPilihProyek.Text = "AI Fraud Detection";
                        break;
                    default:
                        cbPilihProyek.SelectedIndex = -1;
                        break;
                }
        }
    }
}
