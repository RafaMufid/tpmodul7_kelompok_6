using static DataMahasiswa_103022300061;
using static KuliahMahasiswa_103022300061;
using static DataMahasiswa_103022300037;
using static KuliahMahasiswa_103022300037;
using static DataMahasiswa_103022300045;
using static KuliahMahasiswa_103022300045;
using static DataMahasiswa_103022300031;
using static KuliahMahasiswa_103022300031;


class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa_103022300061.ReadJSON();
        KuliahMahasiswa_103022300061.ReadJSON();

        Console.WriteLine();

        DataMahasiswa_103022300037.ReadJSON();
        KuliahMahasiswa_103022300037.ReadJSON();

        Console.WriteLine();

        DataMahasiswa_103022300045.ReadJSON();
        KuliahMahasiswa_103022300045.ReadJSON();

        Console.WriteLine();

        DataMahasiswa_103022300031.ReadJSON();
        KuliahMahasiswa_103022300031.ReadJSON();

        Console.WriteLine("Tekan Enter untuk keluar...");
        Console.ReadLine();
    }
}