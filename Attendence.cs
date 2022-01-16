using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.IO;


namespace Students
{
    public class Attendence
    {

        public int No { get; set; } = 0;

        public string Avatar {get;set;} = "";

        private string Male_Student = "C:/Users/GOD/source/repos/Students/Male_Student.jpg";
        private string Female_Student = "C:/Users/GOD/source/repos/Students/Female_Student.jpg";

        public string Image_Path
        {
            get; set;
        } = "";



        public string Name { get; set; } = "Unknown";
        public string Status { get; set; } = "Absent";
        public string Remark { get; set; } = "";

        public string Subject { get; set; } = "Unknown";

        public int Session { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;
    }
}
