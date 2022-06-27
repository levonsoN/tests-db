using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class TestResult
    {
        public TestResult()
        {
            TestResultAnswers = new HashSet<TestResultAnswer>();
        }

        public long TestResultId { get; set; }
        public long TicketId { get; set; }
        public string StudentName { get; set; } = null!;
        public string StudentSurname { get; set; } = null!;
        public string StudentPatronimyc { get; set; } = null!;
        public string StudentGroup { get; set; } = null!;
        public DateTime ExecutionDate { get; set; }
        public long ExecutionTime { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;
        public virtual ICollection<TestResultAnswer> TestResultAnswers { get; set; }
    }
}
