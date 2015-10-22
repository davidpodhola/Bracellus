namespace Bracellus.PowerShell

open System  
open System.Management.Automation  
open System.ComponentModel  
open Bracellus.Library
 
[<RunInstaller(true)>]  
type BracellusSnapIn() =  
   inherit PSSnapIn()  
   override this.Name with get() = "Bracellus"  
   override this.Vendor with get() = "NašeÚkoly.CZ s.r.o."  
   override this.Description with get() = "Simple Static Blog/Web Generator"  

// for list of verbs see https://technet.microsoft.com/en-us/library/ms714428%28v=vs.85%29.aspx
// for more info see http://blogs.msdn.com/b/fsharpteam/archive/2012/10/03/rethinking-findstr-with-f-and-powershell.aspx

[<Cmdlet(VerbsCommon.New, "Site")>]  
type NewSite() =   
  inherit Cmdlet()  

  [<Parameter>]
  member val Name : string = "My First Site" with get, set

  [<Parameter>]
  member val Folder : string = "site" with get, set

  override this.ProcessRecord() =   
    CreateNewSite() |> ignore
    base.WriteVerbose( sprintf "Site %A in %A created" this.Name this.Folder )

[<Cmdlet(VerbsData.ConvertFrom, "Markdown")>]  
type ConvertFromMarkdown() =   
  inherit Cmdlet()  

  [<Parameter(Mandatory = true, Position = 0)>]
  [<ValidateNotNullOrEmpty>]
  member val Markdown : string = null with get, set

  override this.ProcessRecord() =   
    this.WriteObject( TransformRaw this.Markdown )

