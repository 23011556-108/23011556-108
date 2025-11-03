using System;

namespace Employee_Attendance
{
    public class Attendance
    {
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd} - {EmployeeName} - {(IsPresent ? "Present" : "Absent")}";
        }
    }
}
