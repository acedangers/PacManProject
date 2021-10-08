using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class Map
    {
        public int Id { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public virtual ICollection<WallsAndDots> WallsAndDots { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
    }
}
