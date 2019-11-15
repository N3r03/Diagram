using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace Diagram
{
    [Serializable]
    public class Publisher
    {
        public int pID
        {
            get => default;
            set
            {
            }
        }

        public string pName
        {
            get => default;
            set
            {
            }
        }

        public string pAddress
        {
            get => default;
            set
            {
            }
        }

        public int pNo
        {
            get => default;
            set
            {
            }
        }
        public List<Librarian> PayBills= new List<Librarian>();

    }
}