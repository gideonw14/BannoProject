using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sandbox.Models;

namespace Sandbox
{
  public class GlobalVariables
  {
    public static List<Test> Tests { get; set; } = new List<Test>();
  }
}