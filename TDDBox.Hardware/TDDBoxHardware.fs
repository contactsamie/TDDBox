namespace TDDBoxHardware
open System.IO.Ports
open NUnit.Framework

module HardwareLights = 
  let serialPort= new SerialPort("COM3", 9600, Parity.None,8, StopBits.One)
  let sendData color =
    try 
     serialPort.Open();
     serialPort.Write(color);
     serialPort.Close();
    with | e -> printfn "%A" e


  let red() = sendData "RED"
  let green() = sendData "GREEN"
  let yellow() = sendData "YELLOW"
  let turnoff() = sendData "OFF"

module CheckThat = 
  
  let passed = HardwareLights.green
  let failed = HardwareLights.red
  
  let AreEqual  = 
    fun(x,y)-> 
      if x = y 
        then 
          passed()
          Assert.Pass()
        else 
          failed() 
          Assert.Fail()
      

  let IsTrue  = 
    fun(x)-> 
      if x 
        then 
          passed()
          Assert.Pass()
        else 
          failed() 
          Assert.Fail()