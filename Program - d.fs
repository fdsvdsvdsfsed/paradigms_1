let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let filteredSalaries = 
    salaries
    |> List.filter (fun salary -> salary >= 50000.0 && salary <= 100000.0)

let sumSalariesInRange =
    filteredSalaries
    |> List.fold (fun acc salary -> acc + salary) 0.0

printfn "Filtered salaries between $50,000 and $100,000: %A" filteredSalaries
printfn "Sum of salaries between $50,000 and $100,000: %.2f" sumSalariesInRange