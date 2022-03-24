# Runtime Encoder

## What

This exists purely to jump onboard a blog post I saw.

> Most candidates cannot solve this interview problem:

> Input: "aaaabbbcca"

> Output: [("a", 4), ("b", 3), ("c", 2), ("a", 1)]

> Write a function that converts the input to the output I ask it in the screening interview and give it 25 minutes How would you solve it?

## So?

Well, the article went on to say that it *could* have been as simple as `seq.GroupBy id` if not for the fact we maintain
order. However, this simple fact is the curveball people struggle with.

## Justification for Solution

I feel like the recursive solution reads and feels the nicest. I'll admit my formatting could use some work, or just
more helpers would be beneficial.

## Invocation

Should be as simple as `dotnet run Program.fs aaaabbbcca` 