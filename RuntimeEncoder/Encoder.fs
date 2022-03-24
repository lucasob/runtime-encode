module TextEncoder.Encoder

/// Increment the frequency of the head of the list by one.
/// This works by grabbing the head, incrementing the count
/// by one, and then replacing the head of the list with
/// this new value
let private incrementFrequency (frequencies: ('a * int) list) =
    match frequencies with
    | head :: _ -> (fst head, (snd head) + 1) :: frequencies.[1..]
    | _ -> frequencies


/// Determine if the next entrance is a repeat, and if so
/// increment the frequency lookup within
let private isRepeated (encoding: ('a * int) list) (next: 'a) =
    match encoding with
    | head :: _ -> fst head = next
    | _ -> false


let rec private encode (encoding: ('a * int) list) (inputs: 'a list) =
    match inputs with
    | head :: _ when (isRepeated encoding head) -> encode (incrementFrequency encoding) inputs.[1..]
    | head :: _ -> encode ((head, 1) :: encoding) inputs.[1..]
    | [] -> encoding

let private _runtimeEncode (input: 'a list) = input |> encode [] |> List.rev

/// Given a string, compress the characters and their frequencies
let runtimeEncode (input: string) =
    input.ToCharArray()
    |> List.ofArray
    |> _runtimeEncode