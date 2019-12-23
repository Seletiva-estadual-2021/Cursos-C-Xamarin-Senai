using System;
using System.Collections.Generic;
using System.Text;

namespace KazanTest.model
{
    class Departments
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
}
