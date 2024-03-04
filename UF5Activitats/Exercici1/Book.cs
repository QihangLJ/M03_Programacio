using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Book : IComparable<Book>
    {
        private int id;
        private string title;
        private int numpages;

        public Book(int id, string title, int numpages)
        {
            this.id = id;
            this.title = title;
            this.numpages = numpages;
        }

        public Book(int id, string title) : this(id, title, 0) { }
        public Book() : this (0,"",0) { }

        public void SetId(int id) { this.id = id; }
        public void SetTitle(string title) { this.title = title; }
        public void SetNumPages(int numpages) { this.numpages = numpages; }

        public int GetId() { return id; }
        public string GetTitle() { return title; }
        public int GetNumpages() { return numpages; }

        public override string ToString()
        {
            return $"ID: {this.id} with Title: {this.title} NUM: {this.numpages}";
        }

        public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return this.numpages.CompareTo(other.GetNumpages());
        }
    }
}
