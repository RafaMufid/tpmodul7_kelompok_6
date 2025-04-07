using System;
using System.Text.Json;

public class Nama1
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa1
{
    public Nama1 nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

public class DataMahasiswa_103022300037
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_1_103022300037.json");
            Mahasiswa1 mhs = JsonSerializer.Deserialize<Mahasiswa1>(jsonContent);

            if (mhs != null)
            {
                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            else
            {
                Console.WriteLine("Gagal membaca data mahasiswa dari JSON.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file: {ex.Message}");
        }
    }
}
