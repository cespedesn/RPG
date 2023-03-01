using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Creating base class for HealingPotion and Weapon since they both
    //have the same properties as the Item class.
    //Now a child class of Item.
    public class Weapon : Item
    {
        
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

    }
}
