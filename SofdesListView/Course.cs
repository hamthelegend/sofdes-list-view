using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofdesListView
{
    public class Course
    {
        public string Id { get; }
        public string Name { get; }
        public string Units { get; }

        public Course(string id, string name, int units)
        {
            Id = id;
            Name = name;
            Units = units.ToString();
        }
    }
}
