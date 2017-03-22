using FakeBlog.Controllers.Contracts;
using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.DAL.Repository
{
    public class FakeBlogRepository : IRepository
    {

       /* public void AddBlogPost(string name, ApplicationUser author)
        {
            Post post = new Post { Name = name, Author = author };
            Context.Posts.Add(post);
            Context.SaveChanges();
        } */

        public List<Blog> GetBlogPost(int postId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetPostsFromUser(string userId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetBlogAuthor(int postId)
        {
            throw new NotImplementedException();
        }

        public bool AttachAuthor(string userId, int postId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBlogPost(int postId)
        {
            throw new NotImplementedException();
        }

        public void AddBlogPost(string name, ApplicationUser author)
        {
            throw new NotImplementedException();
        }
    }
}