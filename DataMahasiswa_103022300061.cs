using System;
using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

class DataMahasiswa_103022300061
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_1_103022300061.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);

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
