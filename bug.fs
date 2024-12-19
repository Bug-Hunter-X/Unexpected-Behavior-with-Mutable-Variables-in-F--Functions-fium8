let mutable x = 10
let mutable y = 20

let add x y =  x + y

let mutable z = add x y

printf "%d" z

x <- 100
y <- 200

printf "%d" z // z will still be 30

//The issue is that z is not updated when x and y are updated after it is first calculated.