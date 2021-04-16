module Pangram

let isPangram (input: string): bool =
    let AlphabetSize = 26

    input.ToLowerInvariant()
    |> Seq.filter (fun character -> System.Char.IsLetter(character))
    |> Seq.distinct
    |> Seq.length = AlphabetSize
