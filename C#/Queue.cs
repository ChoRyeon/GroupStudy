using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
  struct Vector2D
  {
    public double x;
    public double y;

    public Vector2D(double x_, double y_)
    {
      x = x_;
      y = y_;
    }

    public double Length()
    {
      double len = 0;
      len = Math.Sqrt(x * x + y * y);
      return len;
    }

    public double Distance(ref Vector2D value)
    {
      return Math.Sqrt(
        Math.Pow(Math.Abs(value.x - x), 2) +
        Math.Pow((double) Math.Abs(value.y - y), 2));
    }

    public static Vector2D DirectionVector(Vector2D from, Vector2D to)
    {
      Vector2D dirVector;
      dirVector.x = to.x - from.x;
      dirVector.y = to.y - from.y;
      return dirVector;
    }

    public void Normalize()
    {
      double Len = Length();
      if (Len == 0)
        Len = 1;
      x /= Len;
      y /= Len;
    }
  }

  class MoveCommand
  {
    private Vector2D vec;

    public MoveCommand(Vector2D vec_)
    {
      vec = vec_;
    }

    public Vector2D GetPosition()
    {
      return vec;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Queue<MoveCommand> MovePoint = new Queue<MoveCommand>();

      MovePoint.Enqueue(new MoveCommand(new Vector2D(100, 0)));
      MovePoint.Enqueue(new MoveCommand(new Vector2D(50, 150)));
      MovePoint.Enqueue(new MoveCommand(new Vector2D(10, 200)));

      Vector2D Goal;
      Vector2D Current;

      Goal.x = 10;
      Goal.y = 10;
      Current.x = 0;
      Current.y = 0;

      while (true)
      {
        Thread.Sleep(300);
        Console.WriteLine("현재 좌표 : X = {0}, Y = {1}", Current.x, Current.y);
        double d = Current.Distance(ref Goal);

        if ( d <= 1)
        {
          MoveCommand GetData = null;
          if (MovePoint.Count == 0)
            break;
          GetData = MovePoint.Dequeue();
          Goal = GetData.GetPosition();
          Console.WriteLine("좌표 {0}, {1}로 목표 수정", Goal.x, Goal.y);
        }
        else
        {
          //도착하지 않았다면 계속해서 목표 지점으로 이동한다.
          Vector2D DirV = Vector2D.DirectionVector(Current, Goal);
          DirV.Normalize();

          Current.x += DirV.x * 2;
          Current.y += DirV.y * 2;
        }
      }

      MovePoint = null;
    }
  }
}
