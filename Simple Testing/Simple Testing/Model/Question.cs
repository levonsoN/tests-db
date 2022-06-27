using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            TestResultAnswers = new HashSet<TestResultAnswer>();
        }

        public long QuestionId { get; set; }
        public long TicketId { get; set; }
        public long QuestionNumber { get; set; }
        public bool IsMultipleAnswers { get; set; }
        public string QuestionText { get; set; } = null!;
        public double Points { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<TestResultAnswer> TestResultAnswers { get; set; }
    }
}
