namespace Services
{
    using System;   

    /// <summary>
    /// Fibonacci service
    /// </summary>
    public class FibonacciService : AbstractService
    {
        /// <summary>
        /// Fib(1)
        /// </summary>
        public const int FIB1 = 1;

        /// <summary>
        /// Fib(2)
        /// </summary>
        public const int FIB2 = 1;

        /// <summary>
        /// Default error value
        /// </summary>
        public const int ERRORVAL = -1;

        /// <summary>
        /// Min value
        /// </summary>
        public const int MINVALUE = 1;

        /// <summary>
        /// Max value
        /// </summary>
        public const int MAXVALUE = 100;        

        /// <summary>
        /// Calculate the Nth value in the Fibonacci sequence   
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns>Fibonacci result</returns>
        public static long Compute(int n)
        {
            long fib = 0, 
                fibn1 = FIB1, 
                fibn2 = FIB2;
          
            try
            {
                if (n < MINVALUE || n > MAXVALUE)
                {
                    fib = ERRORVAL;
                }
                else
                {
                    if (n <= 2)
                    {
                        fib = FIB1;
                    }
                    else
                    {
                        for (int i = 3; i <= n; i++)
                        {
                            fib = fibn1 + fibn2;
                            fibn2 = fibn1;
                            fibn1 = fib;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                fib = ERRORVAL;
                logger.Error(ex);
            }

            return fib;
        }

    }
}
