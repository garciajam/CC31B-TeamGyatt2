using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld() 
        {
            World newWorld = new World();

            newWorld.AddLocation(0,0, "Home", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/home.png");
            newWorld.AddLocation(0, 1, "Enchanted Forest", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/enchantedforest.png");
            newWorld.AddLocation(1, 1, "Caverns of Shadows", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/cavernsofshadows.png");
            newWorld.AddLocation(-1, 1, "Volcanic Forge", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/volcanicforge.png");
            newWorld.AddLocation(0, 2, "City of Ancients", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/cityofancients.png");
            newWorld.AddLocation(1, 2, "Skyward Summit", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/skywardsummit.png");
            newWorld.AddLocation(-1, 2, "Dragon's Peak", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/dragonspeak.png");
            newWorld.AddLocation(-1, 0, "Haunted Graveyard", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/hauntedgraveyard.png");
            newWorld.AddLocation(1, 0, "Crystal Lake Shore", "Placeholder", "pack://application:,,,/Engine;component/Images/Locations/crystallakeshore.png");

            return newWorld;
        }
    }
}
