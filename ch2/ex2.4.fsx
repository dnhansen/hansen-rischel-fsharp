let isIthChar (s: string, i, c) = s.[i] = c

let rec occFromIth = function
    | (s,i,_) when i >= String.length s -> 0
    | (s,i,c) when isIthChar (s,i,c)    -> 1 + occFromIth (s,i+1,c)
    | (s,i,c)                           -> occFromIth (s,i+1,c)

printfn "%i" <| occFromIth ("hello", 2, 'l') // 2