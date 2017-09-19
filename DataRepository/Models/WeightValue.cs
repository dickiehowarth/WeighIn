using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Models
{
    public class WeightValue
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Weight { get; set; }
        public Decimal WeightKg { get; set; }
        public WeightUnit WeightUnit{ get; set; }
    }
}
