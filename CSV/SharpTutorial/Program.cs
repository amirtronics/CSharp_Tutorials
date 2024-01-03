using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data to be written to the CSV file
            List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "John Doe", Age = 30 },
            new Person { Id = 2, Name = "Jane Smith", Age = 25 }
        };

            // Specify the path for the CSV file
            string filePath = "people.csv";

            // Write data to the CSV file
            WriteToCsv(filePath, people);
        }

        static void WriteToCsv<T>(string filePath, IEnumerable<T> records)
        {
            // Configure CsvWriter
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            // Write data to the CSV file
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                // Write records to the CSV file
                csv.WriteRecords(records);
            }

            Console.WriteLine($"CSV file created at: {filePath}");
        }
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}