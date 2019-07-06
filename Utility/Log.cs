using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Efues.Utility
{
  public class Log
  {
    // ロックオブジェクト
    private static readonly object WriteLook = new object();

    #region public methods
    // 書き出す
    public static void Write(string message)
    {
      Write(LogFilePath, message);
    }

    // エラーを書き出す
    public static void WriteError(string message)
    {
      Write(ErrorLogFilePath, message);
    }

    public static void WriteError(Exception exp)
    {
      var msg = exp.Message + System.Environment.NewLine;
      if (exp.StackTrace != null) msg += exp.StackTrace;
      WriteError(msg);
    }
    #endregion

    #region Properties of FilePath
    // 保存ルートディレクトリ
    private static string LogRootDirectory
    {
      get
      {
        var myAssembly = Assembly.GetEntryAssembly();
        return Path.Combine(Path.GetDirectoryName(myAssembly.Location), "Log");
      }
    }

    private static string LogDirPath
    {
      get
      {
        // 対象フォルダ
        string CurrentFolder = Path.Combine(LogRootDirectory , DateTime.Now.ToString("yyyy"));

        // フォルダが無かったら作成
        if (Directory.Exists(CurrentFolder) == false) { Directory.CreateDirectory(CurrentFolder); }
        return CurrentFolder;
      }
    }

    private static string LogFilePathWithoutExtention { get { return Path.Combine(LogDirPath , DateTime.Now.ToString("yyyyMM")); } }

    private static string LogFilePath { get { return LogFilePathWithoutExtention + ".Log"; } }

    private static string ErrorLogFilePath { get { return LogFilePathWithoutExtention + ".ErrLog"; } }
    #endregion

    #region Inner Method
    private static void Write(string filePath, string message)
    {
      if (message == null) return;
      lock (WriteLook)
      {
        using (StreamWriter writer = new StreamWriter(LogFilePath, true, Encoding.GetEncoding("Shift_JIS")))
        {
          writer.WriteLine(string.Format("{0} : {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), message));
        }
      }
    }
    #endregion
  }
}
