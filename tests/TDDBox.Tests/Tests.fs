module TDDBox.Tests

open TDDBox
open TDDBoxHardware
open NUnit.Framework 

[<Test>] 
let ``you can add 6 and 4`` () =
  let result = Library.add 6 4 
  CheckThat.AreEqual(10,result)