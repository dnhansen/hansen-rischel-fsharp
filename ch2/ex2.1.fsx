let divides d n = n % d = 0
let f n = (divides 2 n || divides 3 n) && not (divides 5 n)

printfn "%b" <| f 15 // false