using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanastaWebsite.Core.Classes
{
    public class ResultGallery
    {
        public List<TestResult> Results { get; }
        public string RunSummaryID { get; }
        public string Name { get; }
        public string Date { get; }
        public ResultGallery(List<TestResult> results, string runSummaryId, string name, string date)
        {
            this.Results = results;
            this.RunSummaryID = runSummaryId;
            this.Name = name;
            this.Date = date;
        }
    }
}
