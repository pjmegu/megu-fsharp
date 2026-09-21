module Megu.Compiler.Token

type Token =
    | Def
    | Identifier of string
    | Equal
