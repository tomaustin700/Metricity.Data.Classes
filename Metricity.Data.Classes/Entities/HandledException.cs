using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metricity.Data.Entities
{
    public class HandledException
    {
        public int HandledExceptionId { get; set; }

        public string StackTrace { get; set; }
        public string ExceptionType { get; set; }
        public DateTime Occurred { get; set; }

    }
}
