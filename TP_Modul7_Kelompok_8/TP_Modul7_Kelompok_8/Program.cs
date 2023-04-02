using System;
namespace TP_Modul7_Kelompok_8
{
    public class Program
    {
        public static void Main()
        {
            KuliahMahasiswa1302210008 kuliah = new KuliahMahasiswa1302210008();
            kuliah.readJSON();
            DataMahasiswa1302210008 data = new DataMahasiswa1302210008();
			      data.readJSON();
        }
    }
}
