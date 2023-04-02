using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_Modul7_Kelompok_8
{
    internal class KuliahMahasiswa1302210101
    {
        ListOfCourse kuliah = new ListOfCourse();

        String txt2 = File.ReadAllText(@"./tp7_2_1302210101.json");

        public void readJSON()
        {
            kuliah = JsonSerializer.Deserialize<ListOfCourse>(txt2);
            for (int i = 0; i < kuliah.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {kuliah.courses[i].code} - {kuliah.courses[i].name}");
            }
        }
    }
}
