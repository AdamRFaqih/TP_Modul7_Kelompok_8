using System;
using System.Text.Json;

namespace TP_Modul7_Kelompok_8
{
    public class DataMahasiswa1302210024
    {
        Mahasiswa mahasiswa = new Mahasiswa();

        String TxtFile = File.ReadAllText(@"./tp7_1_1302210024.json");

        public void readJSON()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(TxtFile);
            Console.WriteLine($"Nama {mahasiswa.nama.depan + " " 
                + mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }
}
