let rec pow = function
    | (_, 0) -> ""
    | (s, n) -> s + pow (s, n-1)

println <| pow ("hello", 4) // "hellohellohellohello"