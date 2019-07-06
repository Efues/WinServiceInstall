using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCore
{
  public class EntryPoint
  {
    private static long loopCnt = 0;
    public static void Execute()
    {
      if (loopCnt >= long.MaxValue) loopCnt = 0;
      Efues.Utility.Log.Write($"StartLoop:{loopCnt++}");

      // ここにループの処理を入れる

    }
  }
}
