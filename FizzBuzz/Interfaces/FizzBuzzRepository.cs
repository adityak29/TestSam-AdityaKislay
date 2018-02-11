using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FizzBuzz.Models;

namespace FizzBuzz.Interfaces
{
    public class FizzBuzzRepository:IFizzBuzzRepository
    {
       // public FizzBuzzModel context { get; set; }
        
       // public FizzBuzzRepository getvars= new FizzBuzzRepository();
         //  public IEnumerable<string> GetDisplay(int input)
           //{
            //   int x1 = Convert.ToInt32(input);
            //IEnumerable<string> val = new string[x1];
            //   for (int i = 1; i < x1; i++)
            //   {
            //       int[]val = i;
            //   }

            //   return val;
               //return context.number.GetType(string ,input);
             //   throw new NotImplementedException();
           //}

        public FizzBuzzOutput ComputeResult(FizzBuzzInput input)
        {
            FizzBuzzOutput output = new FizzBuzzOutput();
            int num = input.getNum();
            if (num >= 1 && num <= 1000)
            {
                output.setSuccess(true);
                output.setMessage("Printing list from 1 to "+num);
                // TODO compute the list
                List<string> resultSet = new List<string>();
                for (int i = 1; i <= num; i++)
                {
                    string element = "";
                    if (i % 3 == 0)
                    {
                        element = "fizz ";
                    }

                    if (i % 5 == 0)
                    {
                        element = element+"buzz";
                    }

                    if ((i % 3 != 0) && (i % 5 != 0))
                    {
                        element = "" + i;
                    }
                    resultSet.Add(element);
                }

                output.setResult(resultSet);

            }
            else
            {
                output.setSuccess(false);
                output.setMessage("enter a valid number between 1 and 1000");
            }
            return output;

        }
    }

    
}