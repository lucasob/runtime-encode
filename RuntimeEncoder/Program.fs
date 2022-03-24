open TextEncoder.Encoder

[<EntryPoint>]
let main argv =
    argv.[1] |> runtimeEncode |> Seq.iter (printf "%A")
    0
    