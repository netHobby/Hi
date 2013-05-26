using System;
using System.Diagnostics;
using System.IO.Ports;

namespace Hi.Device
{
    public class MgSerialPort
    {
        #region 事件和字段定义   
        public event PortDataReceivedEventHandle Received;  
        private SerialPort _serialPort;  
        public bool ReceiveEventFlag = false;  //接收事件是否有效 false表示有效   
  
        private static readonly MgSerialPort Instance = new MgSerialPort(); 
        #endregion  
 
        #region 属性定义   
        public string PortName  
        {  
            get { return _serialPort.PortName; }  
            set   
            {   
                _serialPort.PortName = value;
            }  
        }  
        #endregion  
 
        #region 构造函数   
        private MgSerialPort()  
        {  
            LoadSerialPort();  
        }  
  
        private void LoadSerialPort()  
        {  
            _serialPort = new SerialPort
                {
                    BaudRate = 9600,
                    Parity = Parity.Even,
                    DataBits = 8,
                    StopBits = StopBits.One,
                    Handshake = Handshake.None,
                    RtsEnable = true,
                    ReadTimeout = 2000
                };
            _serialPort.DataReceived += DataReceived;  
        }  
 
       
        #endregion        
        
        /// <summary>   
        /// 返回串口对象的单个实例   
        /// </summary>   
        /// <returns></returns>   
        public static MgSerialPort GetSerialPortDao()  
        {           
            return Instance;  
        }         
  
        /// <summary>   
        /// 释放串口资源   
        /// </summary>   
        ~MgSerialPort()  
        {  
            Close();  
        }  
  
        /// <summary>   
        /// 打开串口   
        /// </summary>   
        public void Open()  
        {  
            try  
            {  
                if (!_serialPort.IsOpen)  
                {  
                    _serialPort.Open();                      
                }  
            }  
            catch (Exception ex)  
            {  
                Debug.WriteLine(ex.Message);
                throw;  
            }             
        }  
  
        /// <summary>   
        /// 关闭串口   
        /// </summary>   
        public void Close()  
        {  
            if (_serialPort.IsOpen)  
            {  
                _serialPort.Close();  
            }  
        }  
  
        /// <summary>   
        /// 串口是否打开   
        /// </summary>   
        /// <returns></returns>   
        public bool IsOpen()  
        {  
            return _serialPort.IsOpen;  
        }  

        /// <summary>   
        /// 数据发送   
        /// </summary>   
        /// <param name="data">要发送的数据字节</param>   
        public void SendData(byte[] data)  
        {  
            try  
            {  
                _serialPort.DiscardInBuffer();  
                _serialPort.Write(data, 0, data.Length);  
            }  
            catch (Exception ex)  
            {  
                Debug.WriteLine(ex.Message);
                throw;  
            }  
        }  
  
        /// <summary>   
        /// 发送命令   
        /// </summary>   
        /// <param name="sendData">发送数据</param>   
        /// <param name="receiveData">接收数据</param>   
        /// <param name="overtime">超时时间</param>   
        /// <returns></returns>   
        public int SendCommand(byte[] sendData, ref byte[] receiveData, int overtime)  
        {  
            if (_serialPort.IsOpen)  
            {  
                try  
                {  
                    ReceiveEventFlag = true;        //关闭接收事件   
                    _serialPort.DiscardInBuffer();   //清空接收缓冲区                    
                    _serialPort.Write(sendData, 0, sendData.Length);  
                    System.Threading.Thread.Sleep(50);  
                    int num = 0;  
                    while (num++ < overtime)  
                    {  
                        if (_serialPort.BytesToRead >= receiveData.Length)  
                        {  
                            break;  
                        }  
                        System.Threading.Thread.Sleep(50);  
                    }
                    int ret = _serialPort.Read(receiveData, 0, _serialPort.BytesToRead >= receiveData.Length ? receiveData.Length : _serialPort.BytesToRead);
                    ReceiveEventFlag = false;       //打开事件   
                    return ret;  
                }  
                catch (Exception ex)  
                {  
                    Debug.WriteLine(ex.Message);
                    ReceiveEventFlag = false;  
                    throw;  
                }  
            }  
            return -1;  
        }  
  
        ///<summary>   
        ///数据发送   
        ///</summary>   
        ///<param name="data">要发送的数据字符串</param>   
        public void SendData(string data)  
        {  
            //禁止接收事件时直接退出   
            if (ReceiveEventFlag)  
            {  
                return;  
            }  
            if (_serialPort.IsOpen)  
            {  
                _serialPort.Write(data);  
            }  
        }  
  
         ///<summary>   
         ///将指定数量的字节写入输出缓冲区中的指定偏移量处。   
         ///</summary>   
         ///<param name="data">发送的字节数据</param>   
         ///<param name="offset">写入偏移量</param>   
         ///<param name="count">写入的字节数</param>   
        public void SendData(byte[] data, int offset, int count)  
        {  
            //禁止接收事件时直接退出   
            if (ReceiveEventFlag)  
            {  
                return;  
            }  
            if (_serialPort.IsOpen)  
            {  
                _serialPort.Write(data, offset, count);  
            }  
        }  

        /// <summary>   
        /// 数据接收   
        /// </summary>   
        /// <param name="sender"></param>   
        /// <param name="e"></param>   
        public void DataReceived(object sender, SerialDataReceivedEventArgs e)  
        {  
            //禁止接收事件时直接退出   
            if (ReceiveEventFlag)  
            {  
                return;  
            }  
  
            try  
            {  
                var data = new byte[_serialPort.BytesToRead];  
                _serialPort.Read(data, 0, data.Length);  
                if (Received != null)  
                {  
                    Received(sender, new PortDataReciveEventArgs(data));  
                }  
            }  
            catch (Exception ex)  
            {  
                Debug.WriteLine(ex.Message);  
            }  
              
        } 
    }

    public delegate void PortDataReceivedEventHandle(object sender, PortDataReciveEventArgs e);

    public class PortDataReciveEventArgs : EventArgs
    {
        public byte[] Data { get; set; }

        public PortDataReciveEventArgs()
        {
            Data = null;
        }

        public PortDataReciveEventArgs(byte[] data)
        {
            Data = data;
        }
    }  

}
