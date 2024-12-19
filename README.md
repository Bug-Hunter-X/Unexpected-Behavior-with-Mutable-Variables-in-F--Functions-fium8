# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates an issue where mutable variables are updated in place, but the references to them passed to a function aren't automatically updated when the function returns. This can result in unexpected behavior when the function uses mutable variables and the caller modifies them after the function call.

The file `bug.fs` shows the bug, and `bugSolution.fs` presents the solution to mitigate this issue.  The solution provides alternatives using immutable values or explicitly updating the variable after the function call.