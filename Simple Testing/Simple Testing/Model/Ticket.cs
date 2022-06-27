using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Ticket
    {
        public Ticket()
        {
            Questions = new HashSet<Question>();
            TestResults = new HashSet<TestResult>();
        }

        public long TicketId { get; set; }
        public long TestId { get; set; }
        public long TicketNumber { get; set; }

        public virtual Test Test { get; set; } = null!;
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}
