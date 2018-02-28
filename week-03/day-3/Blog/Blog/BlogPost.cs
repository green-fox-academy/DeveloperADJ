using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    class BlogPost
    {
        public string AuthorName;
        string Title;
        string Text;
        string PublicationDate;

        public BlogPost(string AuthorName = "John Doe", string Title = "Unknown Title", string Text = "Placeholder Text", string PublicationDate = "1970.11.25")
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }
    }
}
