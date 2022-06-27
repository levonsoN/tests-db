using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class TestResultAnswer
    {
        public long TestResultAnwerId { get; set; }
        public long TestResultId { get; set; }
        public long QuestionId { get; set; }
        public long AnswerId { get; set; }

        public virtual Answer Answer { get; set; } = null!;
        public virtual Question Question { get; set; } = null!;
        public virtual TestResult TestResult { get; set; } = null!;
    }
}
