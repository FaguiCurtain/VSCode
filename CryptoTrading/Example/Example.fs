module Example
open Deedle
open System

type Price = {Day: DateTime; Open: float}

[<EntryPoint>]
let main argv =
    let x = "hello world from F#"
    printfn "%A" x

    let prices = 
      [ { Day = DateTime.Now ; Open = 10.1}
        { Day = DateTime.Now.AddDays(1.0); Open = 15.1}
        { Day = DateTime.Now.AddDays(2.0); Open =  9.1} ]
    let df = Frame.ofRecords prices
    printfn "%A" df
    // printfn "%A" argv
    0 // return an integer exit code
