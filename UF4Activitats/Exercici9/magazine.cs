using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class Magazine : AEntertainment
    {
        public Magazine(string name, string editorial, string publicationYear, int volumn, int pageNum, string author, string category) : base(name, editorial, publicationYear, volumn, pageNum, author, category)
        {
            Name = name;
            Editorial = editorial;
            PublicationYear = publicationYear;
            Volumn = volumn;
            PageNum = pageNum;
            Author = author;
            Category = category;
        }

        public string TheEditorial()
        {
            return $"The editorial of this magazine is {Editorial}";
        }

    }
}
