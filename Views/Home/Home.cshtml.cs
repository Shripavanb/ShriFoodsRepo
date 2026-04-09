using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShriFoodsProj.Models;
using System.Collections.Generic;
using System.Linq;


namespace ShriFoodsProj.Views.Home
{
    public class HomeModel : PageModel
    {
        private readonly ProductDbContext _ProductDbContext;

        public List<ProductModel> listProductModel = new List<ProductModel>();
  
        public HomeModel(ILogger<HomeModel> logger, ProductDbContext productDbContext)
        {
            _ProductDbContext = productDbContext;
        }

        //public IActionResult OnPostAddTocart(int productId,string productName, decimal price,int quantity)
        //{
        //    //1.Retrieve the current cart or creata new one
        //    session
        //    var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>('Cart')?? new List<CartItem>();
        //}
        public void OnGet()
        {
            listProductModel = _ProductDbContext.ProductDBTable.ToList();
        }
    }
}
