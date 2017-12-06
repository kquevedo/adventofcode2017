// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open adventofcode2017

// Define your library scripting code here

let myInt = 5
let myFloat = 3.14
let myString = "hello"

let square x = x * x

square 5

let twoToFive = [2;3;4;5]
let oneToFive = 1::twoToFive

let evens list =
    let isEven x = x%2 = 0
    List.filter isEven list

`evens oneToFive