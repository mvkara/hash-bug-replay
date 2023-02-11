// For more information see https://aka.ms/fsharp-console-apps
open System
open FSharp.HashCollections

let s = HashSet.ofSeq [ 1 .. 10 ]

printfn "Hashset contains 6 [%b]" (s |> HashSet.contains 6)

printfn "Hashset contains 20 [%b]" (s |> HashSet.contains 20)