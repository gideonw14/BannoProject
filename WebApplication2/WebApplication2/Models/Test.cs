using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Models
{
  public class Test
  {
    public string Message;

    public static void Create(string Message)
    {
      var test = new Test();
      test.Message = Message;
      GlobalVariables.Tests.Add(test);
    }
    public static List<Test> GetAll()
    {
      return GlobalVariables.Tests;
    }
  }
}