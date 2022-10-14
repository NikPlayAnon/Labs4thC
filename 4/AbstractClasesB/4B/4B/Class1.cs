using System;

namespace _4B
{
    public class HotDrink
    {
        protected int sugar, milk;
        
        public HotDrink() {
            this.milk = 0;
            this.sugar = 0;
        }

        public void Drink()
        {
            Console.WriteLine("milk= " + this.milk);
            Console.WriteLine("sugar= " + this.sugar);
        }
        public void AddMilk(int a)
        {
            this.milk += a;
        }

        public void AddSugar(int a)
        {
            this.sugar += a;
        }
    }

    interface iCup<cup>
    {
        public string Tipe
        {
            get;
            set;
        }
        public string Capacity
        {
            get;
            set;
        }
        public void Refill();
        public void Wash(cup obj);
    }

    public class CupOfCoffee : HotDrink, iCup<CupOfCoffee> {
        int volum=1;
        string BeaNЕ="";
        public string BeaNTipe
        {
            get { return BeaNЕ; }
            set { BeaNЕ = value; }
        }
        public string Tipe
        {
            get { return "coffee"; }
            set { }
        }
        public string Capacity
        {
            get { return Convert.ToString(this.volum); }
            set { }
        }

        new public void Drink()
        {
            Console.WriteLine("milk= " + this.milk);
            Console.WriteLine("sugar= " + this.sugar);
            Console.WriteLine(BeaNTipe);
        }

        new public void AddMilk(int a)
        {
            this.volum+=a;
            this.milk+=a;
        }

        public void Refill()
        {
            string answer = "yes";
            while (answer == "yes")
            {
                this.Drink();
                Console.WriteLine("cost is " + Convert.ToString(this.sugar * 3 + this.milk * 5 + 50));
                Console.WriteLine("do you want a refil? yes/no");
                answer = Console.ReadLine();
            }
        }

        public void Wash(CupOfCoffee obj)
        {
            Console.WriteLine("Wash");
        }
    }

    public class CupOfTea : HotDrink, iCup<CupOfTea>
    {
        int volum = 1;
        string LeafT = "";
        public string LeafType
        {
            get { return "tea"; }
            set { LeafT = value;  }
        }

        public string Tipe
        {
            get { return "tea"; }
            set { }
        }
        public string Capacity
        {
            get { return Convert.ToString(this.volum); }
            set { }
        }

        new public void Drink()
        {
            Console.WriteLine("milk= " + this.milk);
            Console.WriteLine("sugar= " + this.sugar);
            Console.WriteLine(LeafType);
        }

        new public void AddMilk(int a)
        {
            this.volum += a;
            this.milk += a;
        }

        public void Refill()
        {
            string answer = "yes";
            while (answer == "yes")
            {
                this.Drink();
                Console.WriteLine("cost is "+ Convert.ToString(this.sugar*3 + this.milk*5 + 50));
                Console.WriteLine("do you want a refil? yes/no");
                answer = Console.ReadLine();
            }
        }

        public void Wash(CupOfTea obj)
        {
            Console.WriteLine("Wash");
        }
    }

    public class ProcessCup
    {
        public ProcessCup(int tipe)
        {
            if (tipe == 1)
            {
                CupOfTea Cup = new CupOfTea();
                Console.WriteLine("LifeTipe= ");
                Cup.LeafType = Console.ReadLine();
                (int sugar, int milk) = condition();
                Cup.AddMilk(milk);
                Cup.AddSugar(sugar);
                Cup.Refill();
            }
            if (tipe == 2)
            {
                CupOfCoffee Cup = new CupOfCoffee();
                Console.WriteLine("CupOfCoffee= ");
                Cup.BeaNTipe = Console.ReadLine();
                (int sugar,int milk)=condition();
                Cup.AddMilk(milk);
                Cup.AddSugar(sugar);
                Cup.Refill();
            }
        }

        private (int sugar_Out, int milk_Out) condition()
        {
            int sugar = 0;
            int milk = 0;
            string temp = "0";
            while (temp != "")
            {
                Console.WriteLine("1)add sugar\n 2)add milk\n enter blank to prossid");
                temp = Console.ReadLine();
                if (temp == "1")
                {
                    sugar++;
                }
                if (temp == "2")
                {
                    milk++;
                }
            }
            return (sugar, milk);
        }
    }

}
