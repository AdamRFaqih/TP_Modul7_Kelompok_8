using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_Modul7_Kelompok_8
{
    public class KuliahMahasiswa1302210014
    {
        ListOfCourse kuliah = new ListOfCourse();

        string jsonString = File.ReadAllText(@"./tp7_2_1302210014.json");

        public void readJSON()
        {
            kuliah = JsonSerializer.Deserialize<ListOfCourse>(jsonString);
            for (int i = 0; i < kuliah.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {kuliah.courses[i].code} - {kuliah.courses[i].name}");
            }
        }
    }
}
