using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Models
{
    public class FizzBuzzOutput
    {
        public bool success { set; get; }
        public string message { set; get; }
        public List<string> result { set; get; }

        public void setResult(List<string> str)
        {
            result = str;
        }

        public List<string> getResult()
        {
            return result;
        }
        public void setSuccess(bool s)
        {
            success = s;
        }

        public bool isSuccess()
        {
            return success;
        }

        public void setMessage(string m)
        {
            message = m;
        }

        public string getMessage()
        {
            return message;
        }

    }
}