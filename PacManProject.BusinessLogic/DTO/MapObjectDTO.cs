using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject.BusinessLogic.DTO
{
    class MapObjectDTO
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public enum Type { Wall, Dot, PowerDot }
    }
}
