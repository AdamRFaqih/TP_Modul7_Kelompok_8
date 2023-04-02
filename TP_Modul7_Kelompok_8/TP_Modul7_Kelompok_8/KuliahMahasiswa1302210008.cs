using System;
using System.Text.Json;
using System.IO;
namespace TP_Modul7_Kelompok_8
{
	public class KuliahMahasiswa1302210008
	{
		ListOfCourse kuliah = new ListOfCourse();

		public KuliahMahasiswa1302210008()
		{
		}

		public void readJSON()
		{
			string data = File.ReadAllText(@"./tp7_2_1302210008.json");

			kuliah = JsonSerializer.Deserialize<ListOfCourse>(data);

			for (int i = 0; i < kuliah.courses.Count; i++)
			{
                Console.WriteLine($"MK {i + 1} <{kuliah.courses[i].code}> - <{kuliah.courses[i].name}>");
            }

            
        }

    }
}

