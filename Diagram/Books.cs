using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Diagram
{
    public abstract class Books
    {
        public string AddNewBooks;
        public string DeleteBooks;
        public string UpdateBookDetails;
        public string DisplayBookDetails;
        public string SearchBook;

        public string BookId
        {
            get => default;
            set
            {
            }
        }

        public string BookName
        {
            get => default;
            set
            {
            }
        }

        public string BookAuthor
        {
            get => default;
            set
            {
            }
        }

        public string YearOfPub
        {
            get => default;
            set
            {
            }
        }

        public float Price
        {
            get => default;
            set
            {
            }
        }

        public int Status
        {
            get => default;
            set
            {
            }
        }
        public List<Librarian> ListBorrowers = new List<Librarian>();
        public List<User> AddNewUser = new List<User>();

    }
}