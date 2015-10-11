open System

let takeanint() =
    let canparse, keyin = Int32.TryParse(Console.ReadLine())
    if canparse then keyin
    else 0

let ageprint (name:string) (age:int) :string=
    if age >= 20 then
       name + " " + age.ToString() + " is no longer a teenager"
    elif age >13 && age<20 then
       name + " " + age.ToString() + " is a teenage" 
    else
        name + " " + age.ToString() + " is a child"

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Give number of persons")
    let numoftimes=takeanint()
    for i = 1 to numoftimes do
        Console.WriteLine("Give a name")
        let inputname =Console.ReadLine()
        Console.WriteLine("Give an age")
        let inputage = takeanint()
        let output =ageprint inputname   inputage
        Console.WriteLine(output)
    Console.ReadKey()
    0 // return an integer exit code
