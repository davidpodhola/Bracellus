namespace Bracellus

open FSharp.Markdown
open PCLStorage

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

  let Convert markdown =
    Markdown.TransformHtml(markdown)

  let ConvertAndProcess markdown processor : string =
    processor (Convert markdown)

  let ConvertFile file processor =
    let file = FileSystem.Current.GetFileFromPathAsync(file).Result
    let fileContent = file.ReadAllTextAsync().Result
    ConvertAndProcess fileContent processor
