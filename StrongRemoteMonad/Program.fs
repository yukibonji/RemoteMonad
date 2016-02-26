﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open StrongRemoteMonad

[<EntryPoint>]
let main argv = 

    send (Remote.device) <|
        remote{
            do! say "Howdy doodly do"
            do! say "How about a muffin?"
            let! t = temperature
            do! say (sprintf "%dF" t)
            do! toast 4
        }

    ignore <| System.Console.ReadKey() // wait for user input before closing
    0 // return an integer exit code
