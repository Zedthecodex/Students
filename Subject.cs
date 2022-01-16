using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Subject
    {

        public List<Attendence> Attendences { get; set; } = new List<Attendence>();

        string subject_Name { get; set; } = "Name Unassigned";

        string Time { get; set; } = "Awaiting Time assignment";

        string Level { get; set; } = "Unassigned";
    }
}
