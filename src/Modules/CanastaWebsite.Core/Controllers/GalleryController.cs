using CanastaWebsite.Core.Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanastaWebsite.Core.Controllers
{
    public class GalleryController : Controller
    {
        public List<RunSummary> RunList { get; }
        public GalleryController()
        {
            this.RunList = new List<RunSummary>();
        }
        private async Task<List<RunSummary>> ReadAllSummaries()
        {
            string path = "..\\Modules\\CanastaWebsite.Core\\Files\\summaries.json";
            StreamReader streamReader = new StreamReader(path);
            string json = await streamReader.ReadToEndAsync();
            List<RunSummary> runList = JsonConvert.DeserializeObject<List<RunSummary>>(json);
            return runList;
        }

        public async Task<IActionResult> Display()
        {
            List<RunSummary> runList = await ReadAllSummaries();
            RunGallery gallery = new RunGallery(runList);
            return View(gallery);
        }
    }
}
