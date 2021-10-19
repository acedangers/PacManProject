using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.BusinessLogic.DTO;

namespace PacManProject.BusinessLogic.Infrastructure
{
    interface IMazeService
    {
        void GenerateMaze(MapDTO mapDto);
        IEnumerable<GameCharacterDTO> GetGameCharacters();
        IEnumerable<MapObjectDTO> GetMapObjects();
        void Dispose();
    }
}
