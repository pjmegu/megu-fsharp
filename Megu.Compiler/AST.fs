module Megu.Compiler.AST

type Define = { Name: string; Value: Node }

and Node =
    | Root of Node list
    | Define of Define
    | Missing of string
