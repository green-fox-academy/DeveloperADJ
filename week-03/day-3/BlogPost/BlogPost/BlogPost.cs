using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    class BlogPost
    {
        string AuthorName;
        string Title;
        string Text;
        string PublicationDate;

        public BlogPost(string AuthorName, string Title, string Text, string PublicationDate)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }
    }
}
