let rec f = function
    | 0 -> 0
    | n -> n + f (n-1)

printfn "%i" (f 10) // 55