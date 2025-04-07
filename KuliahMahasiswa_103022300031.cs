using System;
using System.Text.Json;

public class Course3
{
    public string code { get; set; }
    public string name { get; set; }
}

public class CourseList3
{
    public List<Course> courses { get; set; }
}

public class KuliahMahasiswa_103022300031
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_2_103022300031.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseList3 courseList = JsonSerializer.Deserialize<CourseList3>(jsonContent, options);

            if (courseList != null && courseList.courses != null)
            {
                Console.WriteLine("Daftar Mata Kuliah yang Diambil:");

                // Gunakan for loop biasa
                for (int i = 0; i < courseList.courses.Count; i++)
                {
                    Console.WriteLine($"- {courseList.courses[i].code}: {courseList.courses[i].name}");
                }
            }
            else
            {
                Console.WriteLine("Data matkul tidak ditemukan atau format salah.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file: {ex.Message}");
        }
    }
}
