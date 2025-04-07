using System;
using System.Text.Json;

public class Nama3
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa3
{
    public Nama3 nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

class DataMahasiswa_103022300031
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_1_103022300031.json");
            Mahasiswa3 mhs = JsonSerializer.Deserialize<Mahasiswa3>(jsonContent);

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
