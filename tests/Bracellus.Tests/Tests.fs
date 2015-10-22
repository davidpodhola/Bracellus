module Bracellus.Tests

open Bracellus
open NUnit.Framework
open PCLStorage

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)

let doNothing more=
    more

[<Test>]
let ``convert file sample1.md`` () =
  let result = Library.ConvertFile (FileSystem.Current) @"..\..\sample1.md" doNothing |> Async.RunSynchronously
  printfn "%s" result
  Assert.AreEqual("# F# Hello world",result)
