using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFish.Domain.Entities
{
    public class Fish
    {
        public int FishID { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string History { get; set; }
        public string Picture { get; set; }
        public int HabitatID { get; set; } 

    }
}
