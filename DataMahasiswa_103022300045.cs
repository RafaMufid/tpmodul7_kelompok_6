using System;
using System.Text.Json;

public class Nama2
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa2
{
    public Nama2 nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

class DataMahasiswa_103022300045
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_1_103022300045.json");
            Mahasiswa2 mhs = JsonSerializer.Deserialize<Mahasiswa2>(jsonContent);

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
