module Bracellus.Tests

open Bracellus
open NUnit.Framework
open Bracellus.Domain
open Serilog

Log.Logger <- LoggerConfiguration()
    .Destructure.FSharpTypes()
    .WriteTo.Console()
    .CreateLogger()
Log.Information( "Tests started" )

[<Test>]
let ``hello returns "Hello "`` () =
  let result = Library.hello {FirstName="John";LastName="Rambo"}
  printfn "%s" result
  Assert.AreEqual("Hello John Rambo",result)
