using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RefrizeratorApp
{
    class Refrizerator
    {
        public int MaxWeight { set; get; }
        public int CurrentWeight { get; private set; }

        public Refrizerator(int maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public int RemainingWeight
        {
            get
            {
                return MaxWeight - CurrentWeight;
            }
        }

        public void AddItems(int NoOfItems, int WeightPerUnit)
        {
            int itemsToBeAdded = NoOfItems*WeightPerUnit;
            if (CurrentWeight + itemsToBeAdded <= MaxWeight)
            {
                CurrentWeight += itemsToBeAdded;
            }
            else
            {
                throw new Exception("Overflow");
            }
        }




    }
}
