# ASP.Net Calculator service by Guy Sharon

This project is an over-engineered version of the SimpleCalculator project  
Meant to demonstrate SOLID principles of very simple functionality.
This project doesn't save anything to DB or memory and is a microservice of sort.

## Arithmetic calculator

This project only implements simple arithmetic calculator, accepting `Add(+)`, `Multiply(x)`, `Substruct(-)` and `Devide(/)`.  
Implementing `ICalculator`, this can be easily replaced with more sophisticated calculators in the future.

## Running the project

run command `dotnet run` or use your preferred IDE.  
The project listens on `port 5146` by default, this is coupled with the `SimpleCalculatorUI` project.

## No input validation

This project doesn't validate input, it is assumed that the input is valid.  
Acceptable input should be in the form of `number operator number` without spaces or gaps (e.g. `1+2` or `3x4`).  
Input can have multiple operators (e.g. `1+2x3-4`).  
Input can begin with a negative number (e.g. `-981+2` or `-143x2`).