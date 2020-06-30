using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_8.ClassInduk;

namespace Tugas_8.ClassAnak
{
    public class sales : Karyawan
    {
        public double jumlahPenjualan { get; set; }
        public double komisi { get; set; }

        public override double Gaji()
        {
            double hasil;
            hasil = jumlahPenjualan * komisi;

            return hasil;      
        }
    }
}
