using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace statica
{
  public class Contador
  {
    private static int num;

    public void IncrementaNum()
    {
      num++;
    }
    public int GetNum()
    {
      return num;
    }
  }
}