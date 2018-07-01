let intValue = 52
let floatValue = 52.0

let testInput x = 
    match x with 
        | 52.0 -> printf "input is a 52.0"
        | 54.0 -> printf "Input is an 54.0"
        | _ -> printf "Unknown value"

testInput 51.0

//casting. 
//numerical values can only be assimilated if they are of the same time
//let result = 1 + 3.4 does not compile (so cast required). 
let result = float 1 + 3.4 //first cast int to float by calling float function

//type mismatches also come into play when using list functions
//[1..20] |> List.average //type in does not support divide by operator!
let x = 1
let y = 5
let averageOf x y = [x..y] |> List.map float |> List.average
let average = averageOf 1 10
printfn "average of %d - %d is %f" x y average