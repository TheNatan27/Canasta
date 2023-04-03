using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanastaWebsite.Core.Classes
{
    public class TestResult
    {
        public TestResult(string name, string result, string script)
        {
            this.Name = name;
            this.Result = result;
            this.Script = script;
        }
        public string Name { get; }
        public string Result { get; }
        public string Script { get; }


    }
}
