let rec sum = function
    | (m,0) -> m
    | (m,n) -> m + n + sum (m, n-1)

printfn "%i" <| sum (2,3) // 14