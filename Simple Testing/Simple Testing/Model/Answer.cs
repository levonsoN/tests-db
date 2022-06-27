using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Answer
    {
        public Answer()
        {
            TestResultAnswers = new HashSet<TestResultAnswer>();
        }

        public long AnswerId { get; set; }
        public long QuestionId { get; set; }
        public string AnswerText { get; set; } = null!;
        public bool IsCorrect { get; set; }

        public virtual Question Question { get; set; } = null!;
        public virtual ICollection<TestResultAnswer> TestResultAnswers { get; set; }
    }
}
