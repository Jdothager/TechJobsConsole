using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsConsole
{
    public class JobComparer : IComparer<Dictionary<string, string>>
    {
        private readonly string fieldName;

        public JobComparer(string fieldName)
        {
            this.fieldName = fieldName;
        }

        public int Compare(Dictionary<string, string> x, Dictionary<string, string> y)
        {
            return String.Compare(x[fieldName], y[fieldName]);
        }
    }
}
