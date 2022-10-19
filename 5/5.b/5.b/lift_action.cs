using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.b
{
    public class lift_action
    {
        bool doors;
        int Aof;
        public int currentFlore;
        public lift_action(int amount_of_flors)
        {
            this.doors = false;
            this.Aof = amount_of_flors;
            this.currentFlore = 1;
        }

        public void close_doors()
        {
            this.doors = true;
        }

        public bool move(int f_to)
        {
            if (this.doors == true)
            {
                this.doors = false;
                this.currentFlore = f_to;
                return true;
            }
            return false;
        }
        


    }
}
