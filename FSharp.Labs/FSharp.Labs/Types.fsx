
//This is an extension method
type System.Int32 with
    member this.IsOdd = this % 2 <> 0

let odd = 5
let result = odd.IsOdd
printf "Number %d is odd = %b" odd result

//Tuples -> How do you get the value out of a tuple? 
let threeValueTuple = "a", 1, false
//printfn "Value at 1 is %d" threeValueTuple

//Record types : Have named fields, semi colomns seperating fields
//If you hover over,    

//The order here is important.
type animial = {Group:string; Size:string}
type person = {Group:string; Size:string}
//If you hover over cat, you'll see it's been inferred that it's a person
//And not an animal. Since last type declarartion is a person
let cat = {Group="Cats"; Size="small"}

///Printing types
//this %A here is a generic way to print (if not using basic types).
printfn "Cat is %A " cat

//NOTE : Here, 1 is output. Printing tuples WIthOUT VALUE ASSIGNMENT DOES NOT WORK!
printfn "can you print array contents? %A" 1,2
let myTuple = 1,3
printfn "print val (variable) ? %A" myTuple

let twoTuple = 1,2
printfn "twoTuple=%A \n" twoTuple