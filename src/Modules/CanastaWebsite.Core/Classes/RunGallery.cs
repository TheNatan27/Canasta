using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanastaWebsite.Core.Classes
{
    public class RunGallery
    {
        public List<RunSummary> Summaries { get; }
        public RunGallery(List<RunSummary> runs)
        {
            this.Summaries = runs;
        }
    }
}
