using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_Modul7_Kelompok_8
{
    internal class DataMahasiswa1302210101
    {
        Mahasiswa mhs = new Mahasiswa();

        String txt = File.ReadAllText(@"./tp7_1_1302210101.json");

        public void readJSON()
        {
            mhs = JsonSerializer.Deserialize<Mahasiswa>(txt);
            Console.WriteLine($"Nama {mhs.nama.depan + " "
                + mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}
