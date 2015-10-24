open Bracellus
open Bracellus.Domain
open Serilog

[<EntryPoint>]
let main argv = 
    Log.Logger <- LoggerConfiguration()
        .Destructure.FSharpTypes()
        .WriteTo.Console()
        .CreateLogger()
    Log.Information( "Console application started" )

    printfn "%A" argv
    printfn "%A" (Library.hello {FirstName="John";LastName="Rambo"})
    0 // return an integer exit code
