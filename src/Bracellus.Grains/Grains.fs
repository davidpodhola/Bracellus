namespace Bracellus.Grains

open Bracellus.Domain
open Bracellus
open Bracellus.Interfaces
open System
open System.Threading.Tasks
open Orleans

type Grain1() = 
    inherit Orleans.Grain()

    interface IHello with

        override this.SayHello(person:Person) =
            Task.FromResult<string>( "Hello world!" )
