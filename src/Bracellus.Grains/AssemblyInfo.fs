﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Bracellus.Grains")>]
[<assembly: AssemblyProductAttribute("Bracellus")>]
[<assembly: AssemblyDescriptionAttribute("Project has no summmary; update build.fsx")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
