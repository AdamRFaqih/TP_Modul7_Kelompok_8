using System;
using System.Text.Json;
using System.IO;

namespace TP_Modul7_Kelompok_8
{
    internal class KuliahMahasiswa1302210024
    {
        ListOfCourse perkuliahan = new ListOfCourse();

        String TxtFile2 = File.ReadAllText(@"./tp7_2_1302210024.json");

        public void readJSON()
        {
            perkuliahan = JsonSerializer.Deserialize<ListOfCourse>(TxtFile2);
            for (int i = 0; i < perkuliahan.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {perkuliahan.courses[i].code} - {perkuliahan.courses[i].name}");
            }
        }
    }
}
