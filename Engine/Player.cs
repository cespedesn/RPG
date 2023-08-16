using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        //Lists are null or non-existent until you set them to an empty list
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        //Constructor
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            //Initialize Fields
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            //Set value of new properties to empty lists. 
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }


    }
}
