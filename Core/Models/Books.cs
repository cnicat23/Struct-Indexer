using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Books
    {
        public static int _no;
        public int No;
        public string Name {  get; set; }
        public string AuthorName { get; set; }
        public double PageCount { get; set; }

        public Books(string name, string authorName, double pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            _no++;
            No = _no;
        }

        public override string ToString()
        {
            return $"No: {No}\nName: {Name}\nAuthorName: {AuthorName}\nPageCount: {PageCount}";
        }
    }
}
