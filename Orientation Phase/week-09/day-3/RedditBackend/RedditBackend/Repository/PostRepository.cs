using RedditBackend.Entities;
using RedditBackend.Models;
using RedditBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repository
{
    public class PostRepository : ICRUDRepository<Post>, IPostRepository
    {
        private RedditContext postContext;

        public PostRepository(RedditContext postContext)
        {
            this.postContext = postContext;
        }

        public Post Create(Post post)
        {
            postContext.Add(post);
            postContext.SaveChanges();
            return post;
        }

        public List<Post> Read()
        {
            return postContext.Posts.ToList();
        }

        public Post Upvote(int id)
        {
            GetPostWith(id).Score++;
            postContext.SaveChanges();

            return GetPostWith(id);
        }

        public Post Downvote(int id)
        {
            GetPostWith(id).Score--;
            postContext.SaveChanges();

            return GetPostWith(id);
        }

        private Post GetPostWith(int id) {
            return postContext.Posts.FirstOrDefault(x => x.Id == id);
        }

        public Post Delete(int id)
        {
            Post deletedPost = GetPostWith(id);
            postContext.Remove(GetPostWith(id));
            postContext.SaveChanges();

            return deletedPost;
        }

        public Post Update(int id, Post newValues)
        {
            Post postToBeUpdated = GetPostWith(id);

            if (newValues.Title != null){
                postToBeUpdated.Title = newValues.Title;
            }

            if (newValues.Url != null)
            {
                postToBeUpdated.Url = newValues.Url;
            }

            postContext.SaveChanges();

            return GetPostWith(id);
        }
    }
}
