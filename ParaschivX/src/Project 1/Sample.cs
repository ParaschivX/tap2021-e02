using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class Sample
    {
        public Guid Id { get; set; }
        public string DataSequence { get; set; }
        public DateTime AnalysisTime {  set { value = DateTime.Now; } }
        public Sample(string s)
        {
            DataSequence = s;
        }
    }
}
