using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject
{
    public class WallsAndDots
    {
        public int Id { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public string type { get; set; }
        public int mapId { get; set; }

        public virtual Map Map { get; set; }
    }
}
