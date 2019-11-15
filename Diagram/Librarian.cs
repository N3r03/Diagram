using System;
using System.Collections.Generic;
using System.Text;

namespace Diagram
{
    public class Librarian
    {
        public string issueBooks;
        public string Return;
        public int CollectFine;
        public int PayBills;
        public string OrderBooks;
        public int IssueId;
        private int SetBooks;

        public int id
        {
            get => default;
            set
            {
            }
        }

        public int Name
        {
            get => default;
            set
            {
            }
        }
        public List<Books> ListBorrowers = new List<Books>();
        public List<User> issueBooks = new List<User>();



    }
}