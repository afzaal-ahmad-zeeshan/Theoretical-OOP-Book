using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class LibraryPerson
    {
        public string Name { get; set; }
        public bool Authorized { get; set; }
    }

    class User : LibraryPerson
    {
        public void ReturnBook(string book) { }
        public void RequestBook(string book) { }
    }

    class Librarian : LibraryPerson
    {
        public void ReturnBook(string book, string person) { }
        public void IssueBook(string book, string person) { }
    }

    class BookShelf
    {
        private List<string> Books { get; set; }

        public string GetBook (int id) { return ""; }
        public string ReturnBook(int id) { return ""; }
    }
}
