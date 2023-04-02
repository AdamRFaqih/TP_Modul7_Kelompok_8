using System;
namespace TP_Modul7_Kelompok_8
{
    public class Program
    {
        public static void Main()
        {
            DataMahasiswa1302210008 data = new DataMahasiswa1302210008();
            data.readJSON();
            KuliahMahasiswa1302210008 kuliah = new KuliahMahasiswa1302210008();
            kuliah.readJSON();

            Console.WriteLine();
            KuliahMahasiswa1302210014 kuliahIsa = new KuliahMahasiswa1302210014();
            kuliahIsa.readJSON();
        }
    }
}
