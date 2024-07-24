// For more information see https://aka.ms/fsharp-console-apps
let sequence = seq {75000; 48000; 120000; 190000; 300113; 92000; 36000}
let salariesList = Seq.toList sequence
let highIncomeSalaries = List.filter (fun salary -> salary > 100000) salariesList
let sumOfHighIncomeSalaries = List.fold (+) 0 highIncomeSalaries

printfn "%A" highIncomeSalaries
printfn "The sum of all high-income salaries is %d" sumOfHighIncomeSalaries