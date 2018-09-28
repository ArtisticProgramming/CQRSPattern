using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern.Application.Interfaces;
using CQRSPattern.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Controllers
{
    public class WordController : BaseController
    {
        private readonly IWordAppService _IWordAppService;
        public WordController(IWordAppService wordAppService)
        {
            _IWordAppService = wordAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            var models = _IWordAppService.GetAll();
            return View();
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordModel = _IWordAppService.GetById(id.Value);

            if (wordModel == null)
            {
                return NotFound();
            }

            return View(wordModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WordViewModel wordViewModel)
        {
            if (!ModelState.IsValid)
                return View(wordViewModel);
            _IWordAppService.Register(wordViewModel);

            //if (IsValidOperation())
            //    ViewBag.Sucesso = "Customer Registered!";

            return View(wordViewModel);
        }
    }
}