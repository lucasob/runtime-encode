module Tests

open System
open Xunit
open TextEncoder.Encoder

[<Fact>]
let ``A single character should have frequency 1`` () =
    Assert.True([('a', 1)] = (runtimeEncode "a"))

[<Fact>]
let ``A repeated character should have frequency 2`` () =
    Assert.True([('a', 2)] = runtimeEncode "aa")

[<Fact>]
let ``An ABA pattern should result in three entries with frequency 1`` () =
    Assert.True([('a', 1); ('b', 1); ('a', 1)] = runtimeEncode "aba")
    
[<Fact>]
let ``Repetitions and letter changes should be picked up appropriately`` () =
    Assert.True([('a', 3); ('b', 2); ('c', 1); ('a', 1)] = runtimeEncode "aaabbca")