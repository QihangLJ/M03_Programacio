using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class Diary : AEntertainment
    {
        public Diary (string name, string editorial, string publicationYear, int volumn, int pageNum, string author, string category) : base(name, editorial, publicationYear, volumn, pageNum, author, category)
        {
            Name = name;
            Editorial = editorial;
            PublicationYear = publicationYear;
            Volumn = volumn;
            PageNum = pageNum;
            Author = author;
            Category = category;
        }

        public string TheAuthor()
        {
            return $"The author of this diary is {Author}";
        }
    }
}
