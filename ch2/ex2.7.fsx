let notDivisible (d,n) = n % d <> 0

let rec test = function
    | (a,b,_) when a > b -> true
    | (a,b,c)            -> notDivisible (a,c) && test (a+1,b,c)

let prime n = test (2,n-1,n)

printfn "prime 13: %b" <| prime 13 // true
printfn "prime 14: %b" <| prime 14 // false

let rec nextPrime n = if prime (n+1) then n+1 else nextPrime (n+1)

printfn "nextPrime 12: %i" <| nextPrime 12 // 13
printfn "nextPrime 13: %i" <| nextPrime 13 // 17