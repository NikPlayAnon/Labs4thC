using System;

namespace AbstractClasses
{
    public class Angle
    {
        Coordinate coord= new Coordinate(0,0);
        int gradus;
        float minut;
        char Direction;
        /// <summary>
        /// idle 0,0,S
        /// </summary>
        public Angle()
        {
            this.gradus = 0;
            this.minut = 0;
            this.Direction = 'S';
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gradus">int</param>
        /// <param name="minut">float</param>
        /// <param name="Direction">N,S,E or W</param>
        public Angle(int gradus, float minut, char Direction)
        {
            this.gradus = gradus;
            this.minut = minut;
            this.Direction = Direction;
        }

        public void GetAngle()
        {
            Console.WriteLine(Convert.ToString(this.gradus) + " " + Convert.ToString(this.minut) + " " + Convert.ToString(this.Direction));
        }
        /// <summary>
        /// set new x and y for coordinate default is 0,0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Coordinate(double x, double y)
        {
            coord.Set(x, y);
        }
        /// <summary>
        /// new angle for your object to move
        /// </summary>
        /// <param name="gradus"></param>
        /// <param name="minut"></param>
        /// <param name="Direction"></param>
        public void NewAngle(int gradus, float minut, char Direction)
        {
            this.gradus = gradus;
            this.minut = minut;
            this.Direction = Direction;
            tick();
        }
        /// <summary>
        /// set new x and y for coordinate default is 0,0 and immediatly set it to move
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="gradus">int</param>
        /// <param name="minut">float</param>
        /// <param name="Direction">N,S,E or W</param>
        public void Coordinate(double x, double y, int gradus, float minut, char Direction)
        {
            coord.Set(x, y);
            this.gradus = gradus;
            this.minut = minut;
            this.Direction = Direction;
            tick();
        }

        private void tick()
        {
            if (this.Direction == 'N'){
                this.gradus += 90;
            }
            if (this.Direction == 'W')
            {
                this.gradus += 180;
            }
            if (this.Direction == 'S')
            {
                this.gradus += -90;
            }
            double Xchange = this.minut * Math.Sin(Convert.ToDouble(this.gradus *Math.PI / 180));
            double Ychange = this.minut * Math.Cos(Convert.ToDouble(this.gradus * Math.PI / 180));
            coord.Vector(Xchange, Ychange); 
        }

        public string coordinateLocation()
        {
            Console.WriteLine(Convert.ToString(coord.GetX()) + " " + Convert.ToString(coord.GetY()));
            return Convert.ToString(coord.GetX()) + " "+ Convert.ToString(coord.GetY());
        }

    }

    public class Coordinate {
        double x;
        double y;
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Set(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Vector(double x,double y)
        {
            this.x += x;
            this.y += y;
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
    }
}
