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
