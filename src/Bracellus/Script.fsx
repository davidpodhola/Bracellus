#r @"..\..\packages\FSharp.Formatting\lib\net40\FSharp.Markdown.dll"
#load "Library.fs"
open Bracellus

let num = Library.hello 42
printfn "%i" num

let document = """
# F# Hello world
Hello world in [F#](http://fsharp.net) looks like this:

    printfn "Hello world!"

For more see [fsharp.org][fsorg].

  [fsorg]: http://fsharp.org "The F# organization." """

printfn "%s" (Library.TransformRaw document)

