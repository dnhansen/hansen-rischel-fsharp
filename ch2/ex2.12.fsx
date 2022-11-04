let rec minSearch f n = if f n = 0 then n else minSearch f (n+1)

let min f = minSearch f 0

printfn "min (fun n -> n*n - 4): %i" <| min (fun n -> n*n - 4) // 2