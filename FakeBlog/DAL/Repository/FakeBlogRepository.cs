using FakeBlog.Controllers.Contracts;
using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FakeBlog.DAL.Repository
{
    public class FakeBlogRepository : IRepository
    {
        IDbConnection _blogConnection;

        public FakeBlogRepository(IDbConnection blogConnection)
        {
            _blogConnection = blogConnection;
            // _trelloConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public void AddBlogPost(string name, ApplicationUser owner)
        {
            //Board board = new Board { Name = name, Owner = owner };
            //Context.Boards.Add(board);
            //Context.SaveChanges();

            _blogConnection.Open();

            try
            {
                var addBlogPostCommand = _blogConnection.CreateCommand();
                addBlogPostCommand.CommandText = "Insert into Blogs(Name,Owner_Id) values(@name,@ownerId)";
                var nameParameter = new SqlParameter("name", SqlDbType.VarChar);
                nameParameter.Value = name;
                addBlogPostCommand.Parameters.Add(nameParameter);
                var ownerParameter = new SqlParameter("owner", SqlDbType.Int);
                ownerParameter.Value = owner.Id;
                addBlogPostCommand.Parameters.Add(ownerParameter);

                addBlogPostCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                _blogConnection.Close();
            }
        }
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

    }
}