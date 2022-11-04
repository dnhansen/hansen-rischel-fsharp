let isIthChar (s: string, i, c) = s.[i] = c

printfn "%b" <| isIthChar ("hello", 0, 'h')