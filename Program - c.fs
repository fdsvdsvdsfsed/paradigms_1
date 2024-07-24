let esalaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let updateSalary acc salary =
    if salary < 49020.0 then
        (salary + 20000.0) :: acc
    else
        acc

let updatedSalaries = List.fold updateSalary [] esalaries

updatedSalaries |> List.iter (printfn "Updated Salary: %.2f")