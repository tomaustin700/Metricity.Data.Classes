using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metricity.Data.Entities
{
    public class Metric
    {
        public int MetricId { get; set; }
        public string ApplicationName { get; set; }
        public string MetricName { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Occurred { get; set; }
        public Metric()
        {
            Occurred = DateTime.Now;
        }
    }
}
