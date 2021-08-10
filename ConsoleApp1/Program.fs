// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open ClassLibrary1

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    printfn $"{Library.greeting}"
    printfn $"{Library.getPizza ()}"
    0 // return an integer exit code