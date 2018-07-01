// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open FSharp.Labs

//given an input, this function will add 2 and then multiply by 3.
//This is function composition 1) adding 2, 2) the next function x3 operates on the result of the function
let add2Times3 = (+) 2 >> (*) 3
let result = add2Times3 10
printfn "result is %d" result  

let doubled n = n * 2
let deductFive n = n - 5 

//This is piping. Passing value into function, 
//from previous function execution
let answer = 10 |> doubled |> deductFive
//Same results achieved through function composition
let sameAnswer = doubled >> deductFive
let sameResult = sameAnswer 10 
printfn "same answer is %d" sameResult
printfn "answer is equal to sameAnswer %b" (answer = sameResult) 