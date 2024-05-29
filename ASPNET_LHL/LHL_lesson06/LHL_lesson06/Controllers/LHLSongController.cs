using LHL_lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LHL_lesson06.Controllers
{
    public class LHLSongController : Controller
    {
        private static List<LHLSong> lHLSongs = new List<LHLSong>()
        {
            new LHLSong{Id=221090037,LHLTitle="Lê Hoàng Long",LHLAuthor="K22CNT3",LHLArtist="NTU",LHLYearRelease="2004"},
            new LHLSong{Id=1,LHLTitle="Lê Hoàng Long",LHLAuthor="K22CNT3",LHLArtist="NTU",LHLYearRelease="2004"},
        };
        // GET: LHLSong
        public ActionResult Index()
        {
            return View(lHLSongs);
        }
        public ActionResult LHLCreate()
        {
            var LhlSong = new LHLSong();
            return View(LhlSong);
        }
    }
}