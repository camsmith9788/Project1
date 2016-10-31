using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Missions.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionFAQ(string mission)
        {
            if(mission == "SLC")
            {
                ViewBag.Name = "Salt Lake City South Mission";
                ViewBag.President = "J. Christopher Lansing";
                ViewBag.StreetAddress = "8060 S 615 E";
                ViewBag.CityStateZip = "SANDY, UT 84070";
                ViewBag.Country = "USA";
                ViewBag.Language = "English";
                ViewBag.Climate = "Dry Continental";
                ViewBag.Religion = "Mormon";
                ViewBag.MissionFlag = "http://www.ldsdb.com/dadmin/modules/flags/images/m/us-UT.png";




            }

            else if (mission == "Mexico")
            {
                ViewBag.Name = "Mexico Guadalajara Mission";
                ViewBag.President = "Gary W. Wagner";
                ViewBag.StreetAddress = "Volcan Vesuvio # 5106 Col. El Colli";
                ViewBag.CityStateZip = "45070 Zapopan Jalisco";
                ViewBag.Country = "Mexico";
                ViewBag.Language = "Spanish";
                ViewBag.Climate = "Humid Subtropical";
                ViewBag.Religion = "Roman Catholocism";
                ViewBag.MissionFlag = "http://rlv.zcache.com/mexico_guadalajara_mission_lds_ctr_postcard-rc72ef9d2854b4048a928e846eaf4a3c5_vgbaq_8byvr_324.jpg";




            }

            else if (mission == "Australia")
            {
                ViewBag.Name = "Brisbane Australia Mission";
                ViewBag.President = "Mark E. McSwain";
                ViewBag.StreetAddress = "PO Box 348";
                ViewBag.CityStateZip = "Hamilton QLD 4007";
                ViewBag.Country = "Australia";
                ViewBag.Language = "English";
                ViewBag.Climate = "Humid Subtropical";
                ViewBag.Religion = "Roman Catholocism";
                ViewBag.MissionFlag = "http://www.latterdayclipart.com/wp-content/uploads/2012/04/Australia-Brisbane-LDS-Mission-Flag-Cutout-Map-300x300.png";




            }
            else
            {

            }

            return View();
        }
    }
}