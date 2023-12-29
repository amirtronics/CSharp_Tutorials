using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "PersonName"
            };

            Visitor visitor = new Visitor
            {
                FirstName = "VisitorName", 
                Patient = "PatientVisiting"
            };

            Patient patient = new Patient
            {
                FirstName = "PatientName",
                Location = "ICU"
            };

            Doctor doctor = new Doctor
            {
                EmployerNumber = 1,
                FirstName = "DoctorName",
                Specialty = "ENT"
            };

            Nurse nurse = new Nurse
            {
                EmployerNumber = 2,
                FirstName = "NurseName",
                Qualification = "RN"

            };

            Custodian custodian = new Custodian
            {
                EmployerNumber = 3,
                FirstName = "CustodianName",
                Schedule = "MWF1"
            };

            Employee softwareEngineer = new Employee
            {
                EmployerNumber = 4,
                FirstName = "SoftwareName"
            };

            List<Person> people = new List<Person> { person, visitor, patient, softwareEngineer, doctor, custodian, nurse };
            foreach(Person myPerson in people)
            {
                PrintName(myPerson);
            }
            
            List<Employee> employees = new List<Employee> { softwareEngineer, doctor, custodian, nurse };
            List<Doctor> doctors = new List<Doctor> { doctor };

            Console.ReadLine();
        }

        private static void PrintName(Person person)
        {
            if(person is Doctor)
                Console.WriteLine(person.GetFullName());
        }
    }
}