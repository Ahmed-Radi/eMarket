using emarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emarket.ViewModels
{
    public class ProductCartsViewModel
    {
        public List<product> products { get; set; }
        public List<cart> carts { get; set; }
    }
}