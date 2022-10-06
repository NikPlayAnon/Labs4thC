using System;

namespace ImaginaryNumbers
{
    public class ImaginaryClass
    {
        float n=0;
        float i = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="N">real</param>
        /// <param name="I">imaginary</param>
        public ImaginaryClass(float N, float I)
        {
            this.n = N;
            this.i = I;
        }
        /// <summary>
        /// print self
        /// </summary>
        /// <returns></returns>
        public string print()
        {
            if (this.i != 0) { return (" " + this.n + " + " + this.i + "i "); }
            else { return (" " + this.n + " "); }
        }
        /// <summary>
        /// print selected IN
        /// </summary>
        /// <param name="NIm">imaginary obgect</param>
        /// <returns></returns>
        public string print(ImaginaryClass NIm)
        {
            if (NIm.i != 0) { return (" " + NIm.n + " + " + NIm.i + "i "); }
            else { return (" " + NIm.n + " "); }
        }
        /// <summary>
        /// ADD to Imaginamy Number 
        /// </summary>
        /// <param name="NIm">Imaginamy Number</param>
        public ImaginaryClass Add(ImaginaryClass NIm)
        {
            ImaginaryClass temp = new ImaginaryClass(this.n+NIm.n, this.i+NIm.i);
            return temp;
        }
        /// <summary>
        /// ADD to Imaginamy Number 
        /// </summary>
        /// <param name="NIm">float</param>
        /// <returns></returns>
        public ImaginaryClass Add(float NIm)
        {
            ImaginaryClass temp = new ImaginaryClass(this.n + NIm, this.i);
            return temp;
        }
        /// <summary>
        /// Subtract Imaginamy Number from
        /// </summary>
        /// <param name="NIm">number you want to subtract</param>
        /// <returns></returns>
        public ImaginaryClass Subtract(ImaginaryClass NIm)
        {
            ImaginaryClass temp = new ImaginaryClass(this.n - NIm.n, this.n - NIm.i);
            return temp;
        }
        /// <summary>
        /// Multiplication to 
        /// </summary>
        /// <param name="NIm">Imaginary number</param>
        /// <returns></returns>
        public ImaginaryClass Multiply(ImaginaryClass NIm)
        {
            float a = this.n;
            float b = this.i;
            float c = NIm.n;
            float d = NIm.i;
            float N = ((a * c) - (b * d));
            float I = ((a * d) + (b * c));
            ImaginaryClass temp = new ImaginaryClass(N,I);
            return temp;
        }
        /// <summary>
        ///  Multiplication to 
        /// </summary>
        /// <param name="NIm">float</param>
        /// <returns></returns>
        public ImaginaryClass Multiply(float NIm)
        {
            ImaginaryClass temp = new ImaginaryClass(this.n*NIm,this.i*NIm );
            return temp;
        }
        /// <summary>
        /// Multiplication to 
        /// </summary>
        /// <param name="NIm">int</param>
        /// <returns></returns>
        public ImaginaryClass Multiply(int NIm)
        {
            ImaginaryClass temp = new ImaginaryClass(this.n * NIm, this.i * NIm);
            return temp;
        }
        /// <summary>
        /// Division by
        /// </summary>
        /// <param name="NIm">Imaginary number</param>
        /// <returns></returns>
        public ImaginaryClass Divine(ImaginaryClass NIm)
        {
            float a = this.n;
            float b = this.i;
            float c = NIm.n;
            float d = NIm.i;
            float N = ((a * c) + (b * d)) / ((c * c) + (d * d));
            float I = ((b * c) - (a * d)) / ((c * c) + (d * d));
            ImaginaryClass temp = new ImaginaryClass(N, I);
            return temp;
        }

    }
}
