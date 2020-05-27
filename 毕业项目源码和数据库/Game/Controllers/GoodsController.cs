using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Game.Controllers
{
    public class GoodsController : Controller
    {
        GameShoppingEntities db = new GameShoppingEntities();
        // GET: Goods
        
        public ActionResult Index(int? typeId)
        {
            List<Good> gList = db.Good.Where(p => typeId == null || p.TypeID == typeId).ToList();
            ViewBag.TypeList = db.Type.ToList();
            ViewBag.ShopCarCount = db.ShopCar.Count();
            return View(gList);
        }
        public ActionResult AddCar(int GoodId)
        {
            ShopCar shopCar = new ShopCar()
            {
                GoodID = GoodId
            };
            db.ShopCar.Add(shopCar);
            db.SaveChanges();
            return View();
        }
        public ActionResult ShoppingCar()
        {
            return View(db.ShopCar.ToList());
        }
    }
}