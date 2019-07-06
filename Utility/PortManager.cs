using System.Collections.Generic;
using System.IO.Ports;
using System.Management;
using System.Text.RegularExpressions;

namespace Efues.Utility
{
  public class PortManager
  {
    // シリアルポート
    public SerialPort SerialPort { get; private set; }

    // コンストラクタ
    public PortManager(SerialPort serialPort)
    {
      this.SerialPort = serialPort;

      // シリアルポートのプロパティ
      this.SerialPort.BaudRate = 9600;
      this.SerialPort.Parity = Parity.None;
      this.SerialPort.DataBits = 8;
      this.SerialPort.StopBits = StopBits.One;
      this.SerialPort.Handshake = Handshake.None;
      this.SerialPort.Encoding = System.Text.Encoding.GetEncoding("utf-8");
    }

    // ComDevice デバイスネーム：COMポートのディクショナリー
    public Dictionary<string, string> DeviceComNameMap
    {
      get
      {
        Dictionary<string, string> deviceNameDic = new Dictionary<string, string>();
        var Pattern = new Regex("(COM[1-9][0-9]?[0-9]?)");

        ManagementClass mcPnPEntity = new ManagementClass("Win32_PnPEntity");
        ManagementObjectCollection manageObjCol = mcPnPEntity.GetInstances();

        //全てのPnPデバイスを探索しシリアル通信が行われるデバイスを随時追加する
        foreach (ManagementObject manageObj in manageObjCol)
        {
          //Nameプロパティを取得
          var namePropertyValue = manageObj.GetPropertyValue("Name");
          if (namePropertyValue == null) { continue; }

          //Nameプロパティ文字列の一部が"(COM1)～(COM999)"と一致するときリストに追加"
          string name = namePropertyValue.ToString();
          var Check = Pattern.Match(name);
          if (Check.Success)
          {
            // Dictionary追加
            if (deviceNameDic.ContainsKey(name)) { deviceNameDic[name] = Check.Value; }
            else { deviceNameDic.Add(name, Check.Value); }
          }
        }
        return deviceNameDic;
      }
    }

    #region public methods/property
    public bool IsConnected
    {
      get
      {
        return SerialPort.IsOpen;
      }
    }

    // COM接続
    public void Connect(string comName)
    {
      //　開いていたら閉じる
      Disconnect();

      // シリアルポートのCOM設定
      this.SerialPort.PortName = comName;

      // シリアルポートオープン
      this.SerialPort.Open();
    }

    public void Disconnect()
    {
      if (this.SerialPort.IsOpen == true) { this.SerialPort.Close(); }
    }

    public string Read()
    {
      return this.SerialPort.ReadLine();
    }
    #endregion
  }
}
