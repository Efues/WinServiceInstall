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
    private long loopCnt = 0;

    public void Init()
    {
      // 初期化処理
      Efues.Utility.Log.Write($"EntryPoint.Init() called");
    }

    public void Finish()
    {
      // 終了処理
      Efues.Utility.Log.Write($"EntryPoint.Finish() called");
    }

    public void Execute()
    {
      if (loopCnt >= long.MaxValue) loopCnt = 0;
      Efues.Utility.Log.Write($"StartLoop:{loopCnt++}");

      // ここにループの処理を入れる
    }
  }
}
