let x = ref 10
let y = ref 20

let add x y =  !x + !y

let z = add x y

printf "%d" z

// Update x and y
x := 100
y := 200

// Update z to reflect the changes in x and y.
let z = add x y

printf "%d" z 