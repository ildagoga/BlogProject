﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogWebProject.Models;
using BlogWebProject.Repositories;
using System.Dynamic;

namespace BlogWebProject.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryWrapper _repositoryWrapper;
        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

       
        public IActionResult Index()
        {
            var postItem = _repositoryWrapper.PostCategory.GetPostsForView();

            return View(postItem);
        }
        [HttpPost]
        public async Task<IActionResult> Index(string categoryString, string titleSearchString, string tagSearchString)
        {
            
            var postItems = _repositoryWrapper.PostCategory.GetPostsForView(titleSearchString, tagSearchString);

            return View(postItems);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
