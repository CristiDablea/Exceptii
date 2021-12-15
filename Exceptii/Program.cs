using System;

namespace Exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            short nr = 0, x;
            double expr;

            try
            {
                Console.Write("Dati un numar pentru extragerea radacinii patrate: ");
                nr = Convert.ToInt16(Console.ReadLine());
                if (nr < 0)
                    throw new Exception("Numarul trebuie sa fie pozitiv");
                Console.Write("Dati impartitorul: ");
                x = Convert.ToInt16(Console.ReadLine());
                if (x == 0)
                    throw new DivideByZeroException("Impartitorul trebuie sa fie un numar diferit de zero");
                expr = Math.Sqrt(nr) / x;
                Console.WriteLine("Rezultatul calculului este: " + expr);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Scrieti un numar in format corect!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Numarul trebuie sa fie cuprins intre -32768 si 32767");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Am tratat eventualele erori");
            }
            Console.ReadKey();
        }
    }
}
