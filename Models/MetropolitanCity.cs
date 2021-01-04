using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class MetropolitanCity
    {
        [DisplayName("Name")]
        public String Name { get; set; }

        [DisplayName("Country")]
        public String Country { get; set; }

        [DisplayName("Population")]
        public long Population { get; set; }

        [DisplayName("Area")]
        public long Area { get; set; }
    }
}
