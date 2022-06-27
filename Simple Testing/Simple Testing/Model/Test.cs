using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Test
    {
        public Test()
        {
            Tickets = new HashSet<Ticket>();
        }

        public long TestId { get; set; }
        public long AuthorId { get; set; }
        public long? DisciplineId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public long QuestionsCount { get; set; }
        public double TotalPoints { get; set; }
        public long ExecutionTime { get; set; }

        public virtual Author Author { get; set; } = null!;
        public virtual Discipline? Discipline { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
