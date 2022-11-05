type Complex = float * float

let (+.) ((a,b): Complex) (c,d) = (a+c, b+d)

let ( *.) ((a,b): Complex) (c,d) = (a*c - b*d, a*d + b*c)

let (~-.) ((a,b): Complex) = (-a, -b)

let mInv (a: float, b: float) =
    let denom = a**2 + b**2
    (a/denom, b/denom)

let (-.) x y = x +. (-.y)

let (/.) x y = x *. mInv y

printfn "(%f, %f)" <|| (1,2) +. (3,4) // (4.0, 6.0)
printfn "(%f, %f)" <|| (1,2) *. (3,4) // (-5.0, -10.0)
printfn "(%f, %f)" <|| -.(1,2) // (-1.0, -2.0)
printfn "(%f, %f)" <|| (1,2) -. (3,4) // (-2.0, -2.0)