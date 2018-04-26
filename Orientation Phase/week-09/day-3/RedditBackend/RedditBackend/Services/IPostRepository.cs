using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Services
{
    public interface IPostRepository
    {
        Post Upvote(int id);
        Post Downvote(int id);
    }
}
