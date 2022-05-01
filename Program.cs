using System;

namespace Modul9Task1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new FormatException();
            exceptions[1] = new ArgumentException();
            exceptions[2] = new FileNotFoundException();
            exceptions[3] = new OverflowException();
            exceptions[4] = new MyException();
            foreach (var item in exceptions)
            {
                try
                {
                    throw item;
                }
                catch (Exception ex) when (ex is FormatException)
                {
                    ExceptionHandler(ex);
                }
                catch (Exception ex) when (ex is ArgumentException)
                {
                    ExceptionHandler(ex);
                }
                catch (Exception ex) when (ex is FileNotFoundException)
                {
                    ExceptionHandler(ex);
                }
                catch (Exception ex) when (ex is OverflowException)
                {
                    ExceptionHandler(ex);
                }
                catch (Exception ex) when (ex is MyException)
                {
                    ExceptionHandler(ex);
                }
            }

        }
        public static void ExceptionHandler(Exception ex)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine(ex.GetType());
            Console.WriteLine(ex.Message);
        }
    }
    class MyException : Exception 
    {
        public override string Message
        {
            get 
            { 
                return "Пользовательское исключение"; 
            }
        }
    }
  
}