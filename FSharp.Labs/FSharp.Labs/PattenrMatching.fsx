//Pattern matching does CASE sensitive matching (if pattern is string based)
let letterMatch x = 
    match x with 
        | "a" -> printf "Matched fooo bar"
        | "aB" -> printf "Case insensitve"
        | "ab" -> printf "Matched ab"
        
        | _ -> printf "unmatched value"

letterMatch "b"
letterMatch "ab"
letterMatch "a"

letterMatch "ab"


//THE FOLLOWING DOES NOT WORK
//SINCE PATTERN MATCHING CAN ONLY WORK WITH TYPE CONSISENCY (What about generics, tuples etc)
let testInput x = 
    match x with 
        | 52.0 -> printf "input is a 52.0"
        | 54 -> printf "Input is an 54.0"
        | _ -> printf "Unknown value"

testInput 51

let add x y =
     x + y

let result = add 1 2
printfn "Sum is %d" result 