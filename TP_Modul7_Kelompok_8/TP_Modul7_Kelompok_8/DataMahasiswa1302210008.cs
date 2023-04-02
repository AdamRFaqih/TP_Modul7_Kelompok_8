using System;
using System.Text.Json;
namespace TP_Modul7_Kelompok_8
{
	public class DataMahasiswa1302210008
	{
		Mahasiswa mahasiswa = new Mahasiswa();

		public DataMahasiswa1302210008()
		{
		}

		string text = File.ReadAllText(@"./tp7_1_1302210008.json");

		public void readJSON()
		{
			mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);

            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
			Console.WriteLine($"Nim : {mahasiswa.nim}");
			Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
		}
	}
}

