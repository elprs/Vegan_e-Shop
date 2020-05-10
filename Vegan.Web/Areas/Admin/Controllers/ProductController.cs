﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan.Services;
using Vegan.Entities;
using Vegan.Database;

namespace Vegan.Web.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        //===================================== Fields =====================================================================
        private UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());


        //===================================== Methods ====================================================================
        [HttpGet]
        public ActionResult Index()
        {
            return View(unitOfWork.Products.GetAll());
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.Products.Add(model);
                    unitOfWork.Complete();
                    unitOfWork.Dispose();
                    return RedirectToAction("Index", "Product");
                }
            }
            catch (Exception ex)
            {
                //TODO: We want to show an error message
                return View();
            }
            return View();
        }

        public ActionResult DetailsProduct(int productId)
        {
            return View(unitOfWork.Products.GetById(productId));
        }

        [HttpGet]
        public ActionResult EditProduct(int productId)
        {
            return View(unitOfWork.Products.GetById(productId));
        }

        [HttpPost]
        public ActionResult EditProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Products.Edit(model);
                unitOfWork.Complete();
                unitOfWork.Dispose();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteProduct(int productId)
        {
            return View(unitOfWork.Products.GetById(productId));
        }

        [HttpPost, ActionName("DeleteProduct")]
        public ActionResult Delete(int productId)
        {

            var product = unitOfWork.Products.GetById(productId);
            unitOfWork.Products.Delete(product);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            return RedirectToAction("Index", "Product");
        }
    }
}