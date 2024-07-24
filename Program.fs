let rec printSalaries lst =
    match lst with
    | [] -> ()
    | head :: tail ->
        printfn "%d" head
        printSalaries tail

let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Salaries:"
printSalaries salaries