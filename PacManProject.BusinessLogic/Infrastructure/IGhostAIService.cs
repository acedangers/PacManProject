using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.BusinessLogic.DTO;

namespace PacManProject.BusinessLogic.Infrastructure
{
    interface IGhostAIService
    {
        void Control(GameCharacterDTO gameCharacterDto);
    }
}
