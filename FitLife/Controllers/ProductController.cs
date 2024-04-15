﻿using FitLife.Controllers;
using FitLife.Core.Contracts;
using FitLife.Core.Services;
using FitLife.Web.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitLife.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly IParticipantService participantService;

        public ProductController(IProductService _productService,
            IParticipantService _participantService)
        {
            productService = _productService;
            participantService = _participantService;

        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel model)
        {

            var products = await productService.AllAsync(model.SearchTerm, model.Sorting);


            model.TotalProductsCount = products.TotalProductsCount;
            model.Products = products.Products;

            return View(model);
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (await productService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await productService.ProductDetailsByIdAsync(id);

            return View(model);
        }
    }
}