using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Students
{
   public class ManageTeacher
    {

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        const string filename = "C:/Users/GOD/source/repos/Students/teachers.csv";

        public void LoadData()
        {
            if (!File.Exists(filename)) return;
            var ts = from t in File.ReadAllLines(filename).Skip(1)
                     let x = t.Split(',')
                     select new Teacher
                     {
                         Username = x[0],
                         Password = x[1],
                         Phone = x[2],
                         QuestionNo = int.Parse(x[3]),
                         Answer = x[4]
                     };
            Teachers.Clear();
            Teachers.AddRange(ts);

            
        }

        public static List<Teacher> LoadGrid()
        {
            var lines = File.ReadAllLines(filename);

            var data = from l in lines.Skip(1)
                       let split = l.Split(',')
                       select new Teacher
                       {
                           Username = split[0],
                           Password = split[1],
                           Phone = split[2],
                           QuestionNo = int.Parse(split[3]),
                           Answer = split[4]
                       };

            return data.ToList();

           
        }



        public void SaveData()
        {
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Username,Password,Phone,QuestionNo,Answer");
                    foreach (var t in Teachers)
                    {
                        sw.WriteLine($"{t.Username},{t.Password},{t.Phone},"
                            + $"{t.QuestionNo}, {t.Answer}");
                    }
                }

            }
        }
    }
}
