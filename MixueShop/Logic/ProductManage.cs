﻿using MixueShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MixueShop.Logic
{
    public class ProductManage
    {
        MixueProjectContext db = new MixueProjectContext();

        public List<Product> GetProducts(int Offset, int Count, string search, int sort)
        {
            List<Product> list = new List<Product>();
            if (search != null)
            {
                list = (from p in db.Products
                        join c in db.Categories
                        on p.CateId equals c.CateId
                        orderby p.ProductPrice ascending
                        where p.ProductName.ToLower().Trim().Contains(search.ToLower().Trim())
                        select new Product
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            Discount = p.Discount,
                            ProductPrice = p.ProductPrice,
                            CateId = p.CateId,
                            Cate = c,
                        }).ToList();
            }
            else
            {
                list = (from p in db.Products
                        join c in db.Categories
                        on p.CateId equals c.CateId
                        orderby p.ProductPrice ascending
                        select new Product
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            Discount = p.Discount,
                            ProductPrice = p.ProductPrice,
                            CateId = p.CateId,
                            Cate = c,
                        }).ToList();
            }
            if (sort != 0)
            {

                list = (from b in list
                        orderby b.ProductPrice descending
                        select b).ToList();
            }

            return list.Skip(Offset - 1).Take(Count).ToList();
        }
        public int getNumberOfProducts(string search, int sort)
        {
            List<Product> list = new List<Product>();
            if (search != null)
            {
                list = db.Products.Where(p => p.ProductName.ToLower().Trim().Contains(search.ToLower().Trim())).ToList();

            }
            else
            {
                list = db.Products.ToList();
            }
            return list.Count();
        }

        public List<Product> getTopProduct()
        {
            List<Product> list=new List<Product>();
            var x = db.OrderDetails.AsQueryable().GroupBy(x => new
            {
                x.ProductId,
                x.Quantity
            }).Select(x => new
            {
                Code = x.Key.ProductId,
                Quantity = x.Sum(x => x.Quantity)
            }).ToList();
            foreach (var item in x.OrderByDescending(p=>p.Quantity))
            {
                list.Add(getProByID(item.Code));
            }
            return list;
        }
        public Product getProByID(int pro)
        {
            return db.Products.SingleOrDefault(p => p.ProductId == pro);
        }
    }
}
