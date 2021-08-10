namespace ClassLibrary1

    module ListTools = 
        let rec nthElt n l =
            match l with
            | [] -> None
            | x::xs ->
                match n with
                | 1 -> Some(x)
                | _ -> nthElt (n-1) xs
                
        let someOrDefault def item =
            match item with
            | Some(item) -> item
            | None -> def
        
        let randomEltOrDefault (l:'a list) def =
            let rand = System.Random()
            l
            |> (l.Length |> rand.Next |> nthElt)
            |> someOrDefault def
            