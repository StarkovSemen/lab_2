open System

let readList () =
    printfn "Введите строки через пробел:"
    let input = Console.ReadLine()
    Array.toList (input.Split(' '))

let add (lst: string list) (symbol: char) =
    List.map (fun str -> str + string symbol) lst

[<EntryPoint>]
let main argv =
    
    let sList = readList()

    printfn "Введите символ:"
    let symbol = Console.ReadLine().[0]

    let List1 = add sList symbol

    printfn "Новый список:"
    List.iter (fun s -> printfn "%s" s) List1

    0

    (*
let readList () =
    printfn "Введите строки через пробел:"
    let input = Console.ReadLine()
    Array.toList (input.Split(' '))

[<EntryPoint>]
let main argv =
    let list = readList()
    let short =
        List.fold (fun acc s ->
            if String.length s < String.length acc then s else acc
        ) (List.head list) list
    printfn "Самая коротка строка: %s" short
    0
    *)