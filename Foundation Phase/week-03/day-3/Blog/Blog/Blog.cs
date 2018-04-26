using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    class Blog
    {
        public List<BlogPost> blogPosts = new List<BlogPost>();

        public void Delete(int atIndex)
        {
            blogPosts.RemoveAt(atIndex);
            Console.WriteLine($"Deleting blogPost at index {atIndex}");
        }

        public void Update(int atIndex, BlogPost blogPost)
        {
            blogPosts.RemoveAt(atIndex);
            blogPosts.Insert(atIndex, blogPost);
            Console.WriteLine($"Inserting {blogPost.AuthorName} at index {atIndex}");
        }

        public static void PrintBlogPosts(Blog blog)
        {
            foreach (var post in blog.blogPosts)
            {
                Console.Write($"{post.AuthorName} ");
            }
            Console.WriteLine();
        }
    }
}
