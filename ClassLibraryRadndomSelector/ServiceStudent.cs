using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRadndomSelector
{
    public class ServiceStudent
    {
        public List<Student> Students = new List<Student>();

        public ServiceStudent()
        {
            
        }

        public void AddStudent()
        {
            Students.Add(new Student());
        }

        public void RemoveStudent (Student student)
        {
            Students.Remove(student);
        }
    }
}
