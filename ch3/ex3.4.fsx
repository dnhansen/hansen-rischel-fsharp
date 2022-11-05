type StraightLine = float * float

let mirrorY ((a,b): StraightLine) = (-a,b)

let mirrorX ((a,b): StraightLine) = (-a,-b)

let lineString ((a,b): StraightLine) = sprintf "%f*x+%f" a b

printfn "%s" <| lineString (1,3)