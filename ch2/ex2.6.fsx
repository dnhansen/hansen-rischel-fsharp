let notDivisible (d,n) = n % d <> 0

printfn "%b" <| notDivisible (2,5) // true
printfn "%b" <| notDivisible (3,9) // false