using System;
using Tugas_8.ClassAnak;
using Tugas_8.ClassInduk;
using System.Collections.Generic;
using System.Linq;

namespace Tugas_8
{
    class Program
    {
        public static int pil { get; set; }

        static void Main(string[] args)
        {
            List<Karyawan> daftarKaryawan = new List<Karyawan>();
            Console.Title = "Tugas Lab 8 : Inheritance,Polymorphism,Abstractions,& Collection";

            menu:
                Console.WriteLine("\n\n=============================");
                Console.WriteLine("\tPilih Menu Aplikasi :");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("=============================");

                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int pil = int.Parse(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                    atas:

                        Console.WriteLine("Tambah Data Karyawan");
                        Console.WriteLine();
                        Console.WriteLine("Jenis Karyawan");
                        Console.WriteLine("1. Karyawan Tetap");
                        Console.WriteLine("2. Karyawan Harian");
                        Console.WriteLine("3. Sales");
                        Console.Write("Masukan pilihan anda : ");
                        int jenis = int.Parse(Console.ReadLine());

                        if (jenis == 1)
                        {
                            Console.WriteLine("Karyawan Tetap");
                            Console.WriteLine();
                            Console.Write("NIK Karyawan \t : ");
                            string _nik = Console.ReadLine();
                            Console.Write("Nama Karyawan \t : ");
                            string _nama = Console.ReadLine();
                            Console.Write("Gaji Bulanan \t :");
                            double _gaji = double.Parse(Console.ReadLine());
                            string _status = "Karyawan Tetap";
                          
                            _karywanTetap(_nik, _nama, _gaji, _status);

                            Console.Write("\ntambah karyawan?[y/n] : ");
                            char t = char.Parse(Console.ReadLine());
                        if(t=='y' || t == 'Y')
                        {
                            goto atas;
                        }else if (t == 'n' || t == 'N')
                        {
                            goto menu;
                        }
                        else
                        {
                            Console.WriteLine("maaf, pilih Y/N saja..");
                        }                       
                        }

                        else if (jenis == 2)
                        {
                            Console.WriteLine("Karyawan Harian");
                            Console.WriteLine();
                            Console.Write("NIK Karyawan \t : ");
                            string _nik = Console.ReadLine();
                            Console.Write("Nama Karyawan \t : ");
                            string _nama = Console.ReadLine();
                            Console.Write("Upah Perjam \t : ");
                            double _upah = double.Parse(Console.ReadLine());
                            Console.Write("Jumlah Jam \t : ");
                            double _jam = double.Parse(Console.ReadLine());
                            string _status = "Karyawan Harian";

                        _karyawanHarian(_nik, _nama, _upah, _jam, _status);

                        Console.Write("\ntambah karyawan?[y/n] : ");
                        char t = char.Parse(Console.ReadLine());
                        if (t == 'y' || t == 'Y')
                        {
                            goto atas;
                        }
                        else if (t == 'n' || t == 'N')
                        {
                            goto menu;
                        }
                        else
                        {
                            Console.WriteLine("maaf, pilih Y/N saja..");
                        }
                        }

                        else if (jenis == 3)
                        {
                            Console.WriteLine("Sales");
                            Console.WriteLine();
                            Console.Write("NIK Karyawan \t : ");
                            string _nik = Console.ReadLine();
                            Console.Write("Nama Karyawan \t : ");
                            string _nama = Console.ReadLine();
                            Console.Write("Jumlah Penjualan :");
                            double _jumlah = double.Parse(Console.ReadLine());
                            Console.Write("Komisi \t :");
                            double _komisi = double.Parse(Console.ReadLine());
                            string _status = "Sales";

                        _sales(_nik, _nama, _jumlah, _komisi, _status);

                        Console.Write("\ntambah karyawan?[y/n] : ");
                        char t = char.Parse(Console.ReadLine());
                        if (t == 'y' || t == 'Y')
                        {
                            goto atas;
                        }
                        else if (t == 'n' || t == 'N')
                        {
                            goto menu;
                        }
                        else
                        {
                            Console.WriteLine("maaf, pilih Y/N saja..");
                        }
                        }

                        else
                        {
                            Console.WriteLine("Maaf , pilihan tidak tersedia...");
                            Console.WriteLine("Press any key for back to the menu.");
                            Console.ReadKey();
                            goto atas;
                        }
                        break;

                 case 2:
                    hapusData();
                    Console.WriteLine("Tekan tombol apapun....");
                    Console.ReadKey();
                    goto menu;
                    break;
                case 3:
                    tampilData();
                    Console.WriteLine("Tekan tombol apapun....");
                    Console.ReadKey();
                    goto menu;
                    break;
                 case 4:
                    Console.Write("Selesai....");
                    break;
                default:
                    Console.WriteLine("pilih menu yang tersedia...");
                    goto menu;
                    break;
                }

            void _karywanTetap(string _nik,string _nama,double _gaji, string _status)
            {
                daftarKaryawan.Add(new karyawanTetap { Nik = _nik, Nama = _nama, gajiBulanan = _gaji, status = _status });
            }

            void _karyawanHarian(string _nik,string _nama, double _upah,double _jam,string _status)
            {
                daftarKaryawan.Add(new karyawanHarian { Nik = _nik, Nama = _nama, upahPerjam = _upah, jumlahJam = _jam , status = _status});
            }
            
            void _sales(string _nik, string _nama, double _jumlah , double _komisi, string _status)
            {
                daftarKaryawan.Add(new sales { Nik = _nik, Nama = _nama, jumlahPenjualan = _jumlah, komisi = _komisi, status = _status }); 
            }

            void tampilData()
            {
                int nomorUrut = 1;

                foreach (Karyawan karyawan in daftarKaryawan)
                {
                    Console.WriteLine("{0}." + " " + "Nik.{1}" + "\t" + "Nama : {2}" + "\t" + "Gaji : {3}"+ "\t"+"Status : {4}"
                        , nomorUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.status, karyawan.status);
                    nomorUrut++;
                }
            }

            void hapusData()
            {
                tampilData();
                Console.WriteLine("\n");
                Console.Write("Masukan NIK yang akan dihapus : ");
                string pilNIK = Console.ReadLine();
                bool cek = false;
                for(int i = 0; i < daftarKaryawan.Count; i++)
                {
                    if(daftarKaryawan[i].Nik == pilNIK)
                    {
                        var delete = daftarKaryawan.Single(r => r.Nik == pilNIK);
                        Console.WriteLine("Data berhasil ditemukan...");
                        Console.WriteLine("Nama\t: " + delete.Nama);
                        Console.WriteLine("Gaji\t: " + delete.Gaji());
                        Console.WriteLine("Status\t: " + delete.status);

                        Console.Write("Yakin ingin menghapus data??[y/n] : ");
                        char lanjut = char.Parse(Console.ReadLine());
                        if(lanjut == 'y' || lanjut == 'Y')
                        {
                            daftarKaryawan.Remove(delete);
                            Console.WriteLine("Data berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("Gagal menghapus data");
                        }
                        cek = true;
                    }
                    if (!cek)
                    {
                        Console.WriteLine("Maaf, NIK tidak ditemukan!\n\n\n");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
