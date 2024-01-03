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
            // Specify the path for the existing CSV file
            string existingFilePath = "people.csv";

            // Load existing data from the CSV file
            List<Person> existingPeople = ReadCsv<Person>(existingFilePath);

            // Add new entries to the existing data
            existingPeople.Add(new Person { Id = 3, Name = "Alice Johnson", Age = 35 });
            existingPeople.Add(new Person { Id = 4, Name = "Bob Williams", Age = 28 });

            // Specify the path for the updated CSV file
            string updatedFilePath = "people.csv";

            // Write the updated data to the CSV file
            WriteToCsv(updatedFilePath, existingPeople);

            Console.WriteLine($"CSV file updated at: {updatedFilePath}");
        }

        static List<T> ReadCsv<T>(string filePath)
        {
            // Configure CsvReader
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            // Read data from the CSV file
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                // Read records from the CSV file
                return csv.GetRecords<T>().ToList();
            }
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