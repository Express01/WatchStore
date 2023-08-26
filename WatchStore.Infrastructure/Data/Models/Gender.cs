using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStore.Infrastructure.Data.Models
{
    public  class Gender
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public virtual List<WristWatch> Watchers { get; set; }
    }
}
