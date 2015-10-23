module Bracellus.Tests

open Bracellus
open NUnit.Framework
open PCLStorage

// note these are running in the .\tests\Bracellus.Tests\bin\Release folder

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)

let doNothing more=
    more

[<Test>]
let ``convert file sample1.md`` () =
  printfn "%s" (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
  let result = Library.ConvertFile (FileSystem.Current) @"..\..\..\..\sample1.md" doNothing |> Async.RunSynchronously
  printfn "%s" result
  Assert.AreEqual("<h1>F# Hello world</h1>\r\n",result)
