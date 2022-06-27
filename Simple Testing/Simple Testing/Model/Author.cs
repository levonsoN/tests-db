using System;
using System.Collections.Generic;

namespace SimpleTesting.Model
{
    public partial class Author
    {
        public Author()
        {
            Tests = new HashSet<Test>();
        }

        public long AuthorId { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Patronimyc { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Test> Tests { get; set; }
    }
}
