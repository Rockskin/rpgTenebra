using System;
using System.Collections.Generic;

namespace RpgTenebraV4.Models
{
    public partial class BookAuthors
    {
        public long BookId { get; set; }
        public long AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
