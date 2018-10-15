using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class FibonacciViewModel
    {
        public IEnumerable<int> Results { get; set; }

        public int NumberRequested { get; set; }

        public bool HasResults
        {
            get { return Results != null && Results.Any(); }
        }
    }
}