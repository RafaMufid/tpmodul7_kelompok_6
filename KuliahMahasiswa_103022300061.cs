using System;
using System.Text.Json;

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class CourseList
{
    public List<Course> courses { get; set; }
}

public class KuliahMahasiswa_103022300061
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("tp7_2_103022300061.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonContent, options);

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
