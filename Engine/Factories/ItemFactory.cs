using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class ItemFactory
    {
        private static List<GameItem> s_GameItems;
        static ItemFactory()
        {
            s_GameItems = new List<GameItem>();
            s_GameItems.Add(new Weapon(1001, "Stick", 100, "pack://application:,,,/Engine;component/Images/Items/stick.png", 1, 2));
            s_GameItems.Add(new GameItem(2001, "Potion", 100, "pack://application:,,,/Engine;component/Images/Items/potion.png"));

        }

        internal static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem item = s_GameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (item != null)
            {
                return item.Clone();
            }
            return null;
        }

    }
}
