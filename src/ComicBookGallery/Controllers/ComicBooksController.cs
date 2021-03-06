﻿using ComicBookGallery.Models;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBook();

            return View(comicBooks);
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                HttpNotFound();
            }
            var comicBooks = _comicBookRepository.GetComicBooks(id.Value);
            

            
            return View(comicBooks);
        }
    }
}





