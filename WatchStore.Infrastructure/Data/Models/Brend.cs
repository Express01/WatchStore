using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStore.Infrastructure.Data.Models
{
    public class Brend
    {
        public int Id { get; set; }
        public string BrendName { get; set; }
        public virtual List<WristWatch> Watches { get; set; }
    }
}
