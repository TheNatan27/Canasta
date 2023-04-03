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
    public class ResultController : Controller
    {
        public List<TestResult> ResultList { get; }
        public ResultController()
        {
            this.ResultList = new List<TestResult>();
        }
        private async Task<List<TestResult>> FillResults()
        {
            string path = "..\\Modules\\CanastaWebsite.Core\\Files\\mockresults.json";
            StreamReader streamReader = new StreamReader(path); string json = await streamReader.ReadToEndAsync();
            List<TestResult> resultList = JsonConvert.DeserializeObject<List<TestResult>>(json);
            return resultList;
        }

        public async Task<IActionResult> Display(string runSummaryID)
        {
            List<TestResult> resultList = await FillResults();
            ResultGallery gallery = new ResultGallery(resultList, runSummaryID, "mockname", "mockdate");
            return View(gallery);
        }
    }
}
