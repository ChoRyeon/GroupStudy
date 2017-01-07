using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test04
{
  class Program
  {
    static void PrintAll(IEnumerator<int> p)
    {
      p.Reset();
      Console.Write("Stack Data => ");
      while (p.MoveNext())
      {
        Console.Write("{0} ", p.Current);
      }
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      Stack<int> sData = new Stack<int>();

      sData.Push(3);
      sData.Push(2);
      sData.Push(1);

      PrintAll(sData.GetEnumerator());

      sData.Push(9);
      PrintAll(sData.GetEnumerator());

      sData.Push(10);
      PrintAll(sData.GetEnumerator());

      int rtnValue = sData.Pop();
      Console.WriteLine("Pop : {0}", rtnValue);
      PrintAll(sData.GetEnumerator());

      rtnValue = sData.Pop();
      Console.WriteLine("Pop : {0}", rtnValue);
      PrintAll(sData.GetEnumerator());
    }

    
  }
}


