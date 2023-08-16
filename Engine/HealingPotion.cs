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
    public class HealingPotion : Item
    {
        //base takes the values from the parameters in the HealingPotion constructor and passes the on to the constructor of the Item class. This is how to get parameters into the base class when instantiating a derived class
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = AmountToHeal;
        }
        public int AmountToHeal { get; set; }


    }
}
