using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public abstract class AEntertainment
    {
        private string? name;
        private string? editorial;
        private string? publicationYear;
        private int volumn;
        private int pageNum;
        private string? author;
        private string? category;

        public string Name { get; set; }
        public string Editorial { get; set; }
        public string PublicationYear { get; set; }
        public int Volumn { get; set; }
        public int PageNum { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public AEntertainment(string name, string editorial, string publicationYear, int volumn, int pageNum, string author, string category)
        {
            Name = name;
            Editorial = editorial;
            PublicationYear = publicationYear;
            Volumn = volumn;
            PageNum = pageNum;
            Author = author;
            Category = category;
        }

        public string GetFullInfo()
        {
            return $"Name: {Name}, Editorial: {Editorial}, Publication Year: {PublicationYear}, Volumn: {Volumn}, Page Number: {PageNum}, Author: {Author}, Category: {Category}";
        }
    }
}
