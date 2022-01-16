using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Linq;


namespace Students
{
   public class ManageAttendance
    {
        public List<Attendence> Attendences { get; set; } = new List<Attendence>();

        string Teacher_Path = "C:/Users/GOD/source/repos/Students/teachers.csv";

        const string Subject_Path = "C:/Users/GOD/source/repos/Students/subjects.csv";

        public string TeacherName { get; set; } = " ";

        //public ManageAttendance(string teacherName)
        //{
        //    TeacherName = teacherName;
        //    Teacher_Path = TeacherName + "-" + Teacher_Path;
        //}


        public void LoadData()
        {
            if (!File.Exists(Subject_Path)) return;
            var ts = from t in File.ReadAllLines(Subject_Path).Skip(1)
                     let x = t.Split(',')
                     select new Attendence
                     {
                         //Image_Path = x[0],
                         Name = x[1],
                         Status = x[2],
                         Remark = x[3],
                         Subject = x[4],
                         Session = int.Parse(x[5]),
                         Date = DateTime.Parse(x[6])
                     };
            Attendences.Clear();
            int i = 1;
            foreach (var t in ts)
            {
                t.No = i++;
                Attendences.Add(t);
            }
        }

        public  List<Attendence> LoadGrid()
        {
            var lines = File.ReadAllLines(Subject_Path);

            var data = from l in lines.Skip(1)
                       let split = l.Split(',')
                       select new Attendence
                       {
                          // Image_Path = split[0],
                           Name = split[0],
                           Status = split[1],
                           Remark = split[2]
                           //Subject = split[3],
                           //Session = int.Parse(split[4]),
                           //Date = DateTime.Parse(split[5])
                       };

            Attendences.Clear();

            int i = 1;
            foreach (var t in data)
            {
                t.No = i++;
                Attendences.Add(t);
            }
            return data.ToList();

        }


        public void SaveData()
        {
            using (var fs = new FileStream(Subject_Path, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Avatar,Name,Status,Remark,Subject,Session,Date");
                    foreach (var t in Attendences)
                    {
                        sw.WriteLine($"{t.Avatar},{t.Name},{t.Status},"
                            + $"{t.Remark},{t.Subject},{t.Session},{t.Date.ToShortDateString()}");
                    } //t.Date.ToShortDateString()
                }

            }
        }
    }
}
