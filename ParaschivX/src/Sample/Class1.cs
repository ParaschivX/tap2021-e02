using System;

namespace Sample
{
    public class Class1
    {
        public Guid Id { get; set; }
        public string DataSequence { get; set; }
        public DateTime AnalysisTime { private get ;    set { value = DateTime.Now; } }



    }
}
