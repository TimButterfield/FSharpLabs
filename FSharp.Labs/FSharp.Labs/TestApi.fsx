//[<Test>]
let baseUri = "http://localhost:4567"
let restOfUri = "problematicOrders/uk?forRdsOrders=true"

let testableUri = sprintf "%s/%s" baseUri restOfUri

printfn "uri is %s" testableUri

//now what? Can you make a call, on a timer, that tests the uri
//and on failure produces a growl pop up