using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Discipline
    {
        public Discipline()
        {
            Tests = new HashSet<Test>();
        }

        public long DisciplineId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Test> Tests { get; set; }
    }
}
