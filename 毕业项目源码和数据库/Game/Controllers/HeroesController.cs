using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
namespace Game.Controllers
{
    public class HeroesController : Controller
    {
        //上下文类
        HeroesBLL heroBLL = new HeroesBLL();

        // GET: LOL
        public ActionResult Index()
        {
            ViewBag.hero = heroBLL.Look1();
            return View();
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Heroes heroes)
        {
            int retult = heroBLL.Insert1(heroes);
            if (retult == 1)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            int retult = heroBLL.Delete1(id);
            if (retult == 1)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            ViewBag.hero = heroBLL.EditDetail1(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Heroes heroes)
        {
            int result = heroBLL.Edit1(heroes);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}