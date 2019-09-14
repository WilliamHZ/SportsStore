using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        //private IProductsRepository repository;
        public int PageSize = 2;
        public IProductsRepository ProductsRepository { get; set; }

        //public ProductController(IProductsRepository productsRepository)
        //{
        //    this.repository = productsRepository;
        //}

        //public ProductController(IProductsRepository productsRepository)
        //{
        //    this.repository = productsRepository;
        //}

        public ViewResult List(int page = 1)
        {
            return View(
                ProductsRepository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
        }
    }
}