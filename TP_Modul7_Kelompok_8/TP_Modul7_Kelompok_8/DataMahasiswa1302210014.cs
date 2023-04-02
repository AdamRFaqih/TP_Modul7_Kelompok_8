using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_Modul7_Kelompok_8
{
    public class DataMahasiswa1302210014
    {
        Mahasiswa mahasiswa = new Mahasiswa();

        String jsonString = File.ReadAllText(@"./tp7_1_1302210014.json");

        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama {mahasiswa.nama.depan + " " + mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }


    }
}
