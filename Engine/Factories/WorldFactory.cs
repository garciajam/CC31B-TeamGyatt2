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

            newWorld.AddLocation(0,0, "Home", "A peaceful village where your journey begins", "pack://application:,,,/Engine;component/Images/Locations/home.png");
            newWorld.AddLocation(0, 1, "Enchanted Forest", "Dense woods filled with magical creatures", "pack://application:,,,/Engine;component/Images/Locations/enchantedforest.png");
            newWorld.AddLocation(1, 1, "Caverns of Shadows", "A dark labyrinthine cave system", "pack://application:,,,/Engine;component/Images/Locations/cavernsofshadows.png");
            newWorld.AddLocation(-1, 1, "Volcanic Forge", "Fiery landscape with rivers of lava", "pack://application:,,,/Engine;component/Images/Locations/volcanicforge.png");
            newWorld.AddLocation(0, 2, "City of Ancients", "A once-great city now in ruins", "pack://application:,,,/Engine;component/Images/Locations/cityofancients.png");
            newWorld.AddLocation(1, 2, "Skyward Summit", "A floating island in the sky", "pack://application:,,,/Engine;component/Images/Locations/skywardsummit.png");
            newWorld.AddLocation(-1, 2, "Dragon's Peak", "A towering mountain where dragons reside", "pack://application:,,,/Engine;component/Images/Locations/dragonspeak.png");
            newWorld.AddLocation(-1, 0, "Haunted Graveyard", "Eerie graveyard with restless spirits", "pack://application:,,,/Engine;component/Images/Locations/hauntedgraveyard.png");
            newWorld.AddLocation(1, 0, "Crystal Lake Shore", "A serene lake surrounded by crystalline formations", "pack://application:,,,/Engine;component/Images/Locations/crystallakeshore.png");

            return newWorld;
        }
    }
}
