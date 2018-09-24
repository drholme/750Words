using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _750Words.Models
{
    public class Word
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public int WordCount { get; set; }

    }

    public class SevenFifty : DbContext
    {
        public DbSet<Word> Words { get; set; }

    }
}