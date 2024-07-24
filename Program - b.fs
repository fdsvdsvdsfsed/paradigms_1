// For more information see https://aka.ms/fsharp-console-apps
let esalaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let calculateTax salary =
    match salary with
    | s when s <= 49020.0 -> s * 0.15
    | s when s <= 98040.0 -> s * 0.205
    | s when s <= 151978.0 -> s * 0.26
    | s when s <= 216511.0 -> s * 0.29
    | _ -> salary * 0.33

let salariesAndTaxes = List.map (fun salary -> (salary, calculateTax salary)) esalaries

salariesAndTaxes |> List.iter (fun (salary, tax) -> printfn "Salary: %.2f, Tax: %.2f" salary tax)