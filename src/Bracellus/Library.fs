namespace Bracellus

open FSharp.Markdown

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42

  let CreateNewSite () =
    0

  let TransformRaw markdown =
    Markdown.TransformHtml(markdown)