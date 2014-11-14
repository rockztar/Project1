﻿using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RateMyDebate.Controllers;
using RateMyDebate.Models;
using RateMyDebate.ViewModels;
using System.Web.WebPages;

namespace RateMyDebateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DebateTest()
        {
            DebateController controller = new DebateController();

            DebateDisplayViewModel result = controller.FindDebate(1) as DebateDisplayViewModel;

            Assert.AreEqual(1, result.Debate.CreatorIdId);
        }

        [TestMethod]
        public void DebateTest2()
        {
            DebateController controller = new DebateController();

            var result = controller.LiveChat(1) as ViewResult;

            Assert.AreEqual("Cake", result.ViewBag.Title);
        }

        [TestMethod]
        public void DebateDisplayTest()
        {
            DebateController controller = new DebateController();

            ViewResult result = controller.Display(1) as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DebateDisplayTest2()
        {
            DebateController controller = new DebateController();

            var result = controller.Display(1) as ViewResult;
            
            var model = result.ViewData.Model as DebateDisplayViewModel;

            Assert.AreEqual(1, model.Debate.DebateId);
        }

        [TestMethod]
        public void DebateLiveChatTest()
        {
            DebateController controller = new DebateController();

            var result = controller.Index(null, null, null);


        }
    }
}