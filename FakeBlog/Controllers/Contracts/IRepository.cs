using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBlog.Controllers.Contracts
{
    interface IRepository
    {
        // Create
        void AddBlogPost(string name, ApplicationUser author);

        // Read
        List<Blog> GetBlogPost(int postId);
       // List GetDraft(int draftId);
        List<Blog> GetPostsFromUser(string userId);
        List<ApplicationUser> GetBlogAuthor(int postId);

        // Update
        bool AttachAuthor(string userId, int postId); // true: successful, false: not successful

        // Delete
        bool RemoveBlogPost(int postId);
        //bool RemoveDraft(int draftId);
    }
}
