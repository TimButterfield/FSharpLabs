//Don't use ! for the not operator. It's a dereferincing operator. 

let isTrue = true
let isFalse = not isTrue

printfn "The value of isTrue is %b" isTrue
printfn "The value of isFalse is %b" isFalse

//for not equal, don't use !=, instead use <>

printfn "isTrue and isFalse are not equal %b " (isTrue <> isFalse)