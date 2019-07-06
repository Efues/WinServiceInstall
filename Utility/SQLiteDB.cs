using System;
using System.Data.SQLite;
using System.Reflection;
using System.Data.Linq;
using System.IO;

namespace Efues.Utility
{
  public class SQLiteDB : IDisposable
  {
    protected readonly string _DBFile;
    private readonly SQLiteConnection _connection;
    private readonly DataContext _dataContext;

    protected DataContext DataContext { get { return _dataContext; } }

    public SQLiteDB(string DBFilePath)
    {
      _DBFile = DBFilePath;
      if (!File.Exists(_DBFile))
      {
        throw new FileNotFoundException("DBファイルが見つかりません", _DBFile);
      }
      _connection = new SQLiteConnection("DataSource=" + _DBFile);
      _dataContext = new DataContext(_connection);
    }

    public void Dispose()
    {
      _dataContext.Dispose();
      _connection.Dispose();
    }
  }
}
