﻿module CodeSplitting

open Fable.Core.JsInterop
open Feliz

let myCodeSplitComponent = React.functionComponent(fun () ->
    Html.div [
        prop.testId "async-load"
        prop.text "Loaded"
    ])

#if JAVASCRIPT
// ctrl+f friendliness
#else
exportDefault myCodeSplitComponent
#endif