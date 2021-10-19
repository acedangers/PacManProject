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
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual ICollection<MapObject> WallsAndDots { get; set; }
        public virtual ICollection<GameCharacter> Entities { get; set; }
    }
}
