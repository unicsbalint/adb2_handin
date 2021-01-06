using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adb2_handInProject
{
    public class author
    {
        private int authorId;

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        private string authorName;

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        private int numberOfBooks;

        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        }


    }
}
