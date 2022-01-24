namespace lib

open System
open System.Runtime.CompilerServices
[<assembly: InternalsVisibleTo("console")>]
do ()

type internal X() = class end

type IFoo =
    abstract Invoke<'T when 'T :> ICloneable> : value: 'T -> Unit
