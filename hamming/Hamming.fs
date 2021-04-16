module Hamming

let distance (strand1: string) (strand2: string): int option =
    if strand1.Length <> strand2.Length then
        None
    else
        Some
            (Seq.zip strand1 strand2
             |> Seq.map (fun (x, y) ->
                 if x = y then 0 else 1)
             |> Seq.sum)
