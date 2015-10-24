namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Bracellus.PowerShell")>]
[<assembly: AssemblyProductAttribute("Bracellus")>]
[<assembly: AssemblyDescriptionAttribute("Static Blog/Web Generator in F#")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
