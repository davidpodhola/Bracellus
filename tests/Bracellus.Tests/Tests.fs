module Bracellus.Tests

open Bracellus
open NUnit.Framework
open PCLStorage

// note these are running in the .\tests\Bracellus.Tests\bin\Release folder

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  Assert.AreEqual(42,result)

let doNothing more=
    more

[<Test>]
let ``convert file sample1.md`` () =
  let result = Library.ConvertFile (FileSystem.Current) @"..\..\..\..\sample1.md" doNothing |> Async.RunSynchronously
  Assert.AreEqual("<h1>F# Hello world</h1>\r\n",result)
