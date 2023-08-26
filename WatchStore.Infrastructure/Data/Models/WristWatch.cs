using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStore.Infrastructure.Data.Models
{
    public class WristWatch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Picture { get; set; }
        public int BrendId { get; set; }
        public Brend? Brend { get; set; }
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
    }
}
