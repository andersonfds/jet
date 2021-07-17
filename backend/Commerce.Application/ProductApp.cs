﻿using AutoMapper;
using Commerce.Application.Base;
using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
using Commerce.BLL.Core;
using Commerce.Domain.Entity;
using Commerce.Domain.Interfaces;
using System.Collections.Generic;

namespace Commerce.Application
{
    public class ProductApp : BaseApp, IProductApp
    {
        protected readonly IProductBLL ProductBLL;

        public ProductApp(IProductBLL productBLL, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            ProductBLL = productBLL;
        }

        public void CreateProduct()
        {
        }

        public IEnumerable<ProductResponseDTO> GetProductsCatalog()
        {
            return Done<IEnumerable<ProductResponseDTO>>(ProductBLL.GetProductsCatalog());
        }

        public void GetProductDetails()
        {
        }
    }
}