using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    // Struct to represent a student
    public struct Student
    {
        // Student ID
        public int StudentId { get; set; }
        // First name of the student
        public string FirstName { get; set; }
        // Last name of the student
        public string LastName { get; set; }
        // Address of the student
        public string Address { get; set; }
        // Month of admission as an enum
        public MonthOfAdmission MonthOfAdmission { get; set; }
        // Grade of the student as an enum
        public Grade Grade { get; set; }
    }

    // Enum to represent the grade of a student
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    // Enum to represent the month of admission
    public enum MonthOfAdmission
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

}
