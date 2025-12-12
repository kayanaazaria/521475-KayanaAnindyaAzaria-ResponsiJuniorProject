using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunproKay
{
    public class Developer
    {
        private string _nama;
        public string IdDev { get; set; }
        public string NamaDeveloper
        {
            get { return _nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nama tidak boleh kosong.");
                }
                _nama = value;
            }
        }
        public string StatusKontrak { get; set; }
        public int FiturSelesai { get; set; }
        public int JumlahBug { get; set; } 
        public int IdProyek { get; set; }
    }
}
