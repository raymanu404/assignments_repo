#define CONDITION 
using System;
using System.Diagnostics;
using System.IO;
using MainApplication;

public class Program
{
    static void Main(String[] args)
    {
        try
        {
            var result = Divide(100,10);
            Console.WriteLine(result);

            PrintRandomElement(new int[] { 1, 2, 3, 4, 5 }, 2);

            string number = "23";
            PrintMyInteger(number);
            SomeMethod();

        }
        catch (ArithmeticException ex)
        {
            Log(ex);
            throw;

        }
        catch (ArgumentNullException ex)
        {
            Log(ex);
            throw;

        }
        catch (IndexOutOfRangeException ex)
        {
            Log(ex);
            throw;

        }
        catch (ExceptionA ex)
        {
            Log(ex);
            throw;    

        }catch(ExceptionB ex)
        {
            Log(ex);
           
        }catch(Exception ex)
        {
            Log(ex);
        }    
    }

    private static void SomeMethod()
    {
        Stream stream = null;
      
        //v1
        try
        {
            stream = File.Open("random file", FileMode.Append);
            
            if (!stream.CanRead)
            {
                throw new ExceptionA("Cannot read this file");
            }
            

        }catch(ExceptionA ex)
        {
            Log(ex);
            throw new ExceptionA("Exception type A", ex);

        }catch(ExceptionB ex)
        {
            Log(ex);
            throw new ExceptionB("Exception Type B", ex);
        }
        finally
        {
            if(stream != null)
            {
                stream.Dispose();
            }  
        }
#if CONDITION
        //v2
        using ( var file2 = File.Open("fajhgahig random file", FileMode.Open))
        {
            //your code here
        }
#endif
        //v3
        using var file3 = File.Open("random file", FileMode.Create);     //cine implementeaza IDisposable se poate folosi using
        //your code here
    }
    
    public static double Divide(double divider, double divisor)
    {
        if(divisor == 0)
        {
            throw new ArithmeticException("Attempted to divide by 0");
        }

        return divider / divisor;
    }

    public static void PrintRandomElement(int[] array, int nElem)
    {
        if(array == null)
            throw new ArgumentNullException("Attempted to be null");
        if (nElem >= array.Length)
            throw new IndexOutOfRangeException("Attempted to access element in outside of array");

        Console.WriteLine(array[nElem]);
    }

    [Conditional("CONDITION")]
    public static void PrintMyInteger(string number)
    {
        
        if (Int32.TryParse(number, out int result))
        {
            Console.WriteLine(result);
        }
        else
            throw new ExceptionA("Invalid number!");

    }

    public static void Log(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }



}