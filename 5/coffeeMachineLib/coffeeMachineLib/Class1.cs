using System;

namespace coffeeMachineLib
{
    public class HotDrink
    {
        public int price = 20;
        public bool milk, sugar;
        public HotDrink()
        {
            this.milk = false;
            this.sugar = false;
            this.price = 20;
        }
        void switch_milk()
        {
            if (this.milk == false) { this.milk = true;price += 10; }
            else { this.milk = false; price -= 10; }
        }
        void switch_sugar()
        {
            if (this.sugar == false) { this.sugar = true; price += 10; }
            else { this.sugar = false; price -= 10; }
        }
    }
    public interface priceOpps
    {
        public bool isitenough(int value);
        public int change(int value);
    }
    public class americano : HotDrink, priceOpps
    {
        /*public americano()
        {
            this.milk = false;
            this.sugar = false;
            this.price = 50;
        }*/
        
        public bool isitenough(int value)
        {
            return (value > this.price);
        }
        public int change(int value)
        {
            return (value - this.price);
        }
    }

    public class cacao : HotDrink, priceOpps
    {
        /*public cacao()
        {
            this.milk = false;
            this.sugar = false;
            this.price = 70;
        }*/
        public bool isitenough(int value)
        {
            return (value > this.price);
        }
        public int change(int value)
        {
            return (value - this.price);
        }
    }
    public class capuchino : HotDrink, priceOpps
    {
        /*public capuchino()
        {
            this.milk = false;
            this.sugar = false;
            this.price = 40;
        }*/
        public bool isitenough(int value)
        {
            return (value > this.price);
        }
        public int change(int value)
        {
            return (value - this.price);
        }
    }
    public class espresso : HotDrink, priceOpps
    {
        /*public espresso()
        {
            this.milk = false;
            this.sugar = false;
            this.price = 60;
        }*/
        public bool isitenough(int value)
        {
            return (value > this.price);
        }
        public int change(int value)
        {
            return (value - this.price);
        }
    }
}
