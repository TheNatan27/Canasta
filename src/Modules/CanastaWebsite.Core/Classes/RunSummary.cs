using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanastaWebsite.Core.Classes
{
    public class RunSummary
    {
        public RunSummary(string name, string date, string id)
        {
            this.Name = name;
            this.Date = date;
            this.ID = id;
        }
        public string Name { get; }
        public string Date { get; }
        public string ID { get; }
    }
}
