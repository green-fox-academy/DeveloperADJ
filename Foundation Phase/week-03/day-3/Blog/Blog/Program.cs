using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Blog
            Reuse your BlogPost class
            Create a Blog class which can
                store a list of BlogPosts
                add BlogPosts to the list
                delete(int) one item at given index
                update(int, BlogPost) one item at the given index and update it with another BlogPost*/

            var blog = new Blog();

            blog.blogPosts.Add(new BlogPost("0"));
            blog.blogPosts.Add(new BlogPost("1"));
            blog.blogPosts.Add(new BlogPost("2"));
            blog.blogPosts.Add(new BlogPost("3"));
            blog.blogPosts.Add(new BlogPost("4"));
            blog.blogPosts.Add(new BlogPost("5"));

            Blog.PrintBlogPosts(blog);

            blog.Update(1, new BlogPost("new"));

            Blog.PrintBlogPosts(blog);

            blog.Delete(1);

            Blog.PrintBlogPosts(blog);

            blog.Delete(3);

            Blog.PrintBlogPosts(blog);

            Console.ReadLine();
        }
    }
}
