using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace ResponsiJunproKay
{
    public class DeveloperRepository : ConnectionDB
    {
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                string sql = "SELECT * FROM dev_select()";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public void AddDeveloper(Developer d)
        {
            OpenConnection();
            string sql = "SELECT dev_insert(@nama, @status_kontrak, @fitur_selesai, @jumlah_bug, @id_proyek)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nama", d.NamaDeveloper);
                cmd.Parameters.AddWithValue("@status_kontrak", d.StatusKontrak);
                cmd.Parameters.AddWithValue("@fitur_selesai", d.FiturSelesai);
                cmd.Parameters.AddWithValue("@jumlah_bug", d.JumlahBug);
                cmd.Parameters.AddWithValue("@id_proyek", d.IdProyek);
                cmd.ExecuteScalar();
            }
            CloseConnection();
        }
        public void EditDeveloper(Developer d)
        {
            OpenConnection();
            string sql = "SELECT dev_update(@id_dev, @nama, @status_kontrak, @fitur_selesai, @jumlah_bug, @id_proyek)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_dev", d.IdDev);
                cmd.Parameters.AddWithValue("@nama", d.NamaDeveloper);
                cmd.Parameters.AddWithValue("@status_kontrak", d.StatusKontrak);
                cmd.Parameters.AddWithValue("@fitur_selesai", d.FiturSelesai);
                cmd.Parameters.AddWithValue("@jumlah_bug", d.JumlahBug);
                cmd.Parameters.AddWithValue("@id_proyek", d.IdProyek);
                cmd.ExecuteScalar();
            }
            CloseConnection();
        }
        public void DeleteDeveloper(string idDev)
        {
            OpenConnection();
            string sql = "SELECT dev_delete(@id_dev)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id_dev", idDev);
                cmd.ExecuteScalar();
            }
            CloseConnection();
        }
    }
}
