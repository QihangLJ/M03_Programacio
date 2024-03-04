using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return -x.GetNumpages().CompareTo(y.GetNumpages());
        }
    }
}