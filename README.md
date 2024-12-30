This example demonstrates a common misunderstanding in F# regarding mutable variables and function parameters.  In F#, mutable variables are not passed by reference to functions; instead, copies of their values are passed.  Therefore, modifications within the function do not affect the original variables.

The `bug.fs` file contains code that attempts to swap two mutable variables using a function but fails due to this behavior.

The `bugSolution.fs` file demonstrates how to correctly swap mutable variables, either by using tuples to return modified values or by using a reference cell.