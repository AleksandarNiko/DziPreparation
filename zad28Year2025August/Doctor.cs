using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025August
{
    public class Doctor: HospitalStaff
    {
        public Doctor(string firstName, string lastName, int age, decimal salary, string specialization, int patientsTreated)
            : base(firstName, lastName, age, salary)
        {
            Specialization = specialization;
            PatientsTreated = patientsTreated;
        }

        public  string Specialization { get; set; }

        public  int PatientsTreated { get; set; }

        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Doctor: {FirstName} {LastName} - {Specialization}");
            sb.AppendLine($"Salary: {Salary:f2}");
            sb.AppendLine($"Age: {Age}");
            sb.AppendLine($"Patients treated: {PatientsTreated}");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
