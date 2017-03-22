using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FakeBlog.Models;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using FakeBlog.Repository;

namespace FakeBlog.Tests.DAL
{
    [TestClass]
    public class FakeBlogRepoTests
    {
        [TestMethod]
        public void EnsureICanCreateInstanceOfContext()
        {
            FakeBlogRepository repo = new FakeBlogRepository();

            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void EnsureIHaveNotNullContext()
        {
            FakeBlogRepository repo = new FakeBlogRepository();

            Assert.IsNotNull(repo.Context);
        }

        [TestMethod]
        public void EnsureICanInjectContextInstance()
        {
            FakeBlogContext context = new FakeBlogContext();
            FakeBlogRepository repo = new FakeBlogRepository(context);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
