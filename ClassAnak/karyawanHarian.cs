using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_8.ClassInduk;

namespace Tugas_8.ClassAnak
{
    public class karyawanHarian : Karyawan
    {
        public double upahPerjam { get; set; }
        public double jumlahJam { get; set; }

        public override double Gaji()
        {
            double hasil;
            hasil = upahPerjam* jumlahJam;

            return hasil;
        }
    }
}
