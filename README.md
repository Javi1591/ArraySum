# Assignment 7 – Random Array Sum (C#)

A C# console application that generates an array of random integers and calculates their cumulative total as they are displayed.  
This assignment demonstrates array initialization, loop iteration, random number generation, and running totals.

---

## Description
The program creates an array of ten random integers ranging from 1 to 100 and prints each element’s value as it is generated.  
It maintains a running total that updates and displays after each iteration.  
This assignment reinforces fundamental array concepts and control flow using for loops.

---

## Features
- Initializes an integer array of length 10.  
- Populates each array element with a random number between 1 and 100.  
- Displays the current element index, value, and cumulative total after each addition.  
- Uses the Random class for number generation.  
- Demonstrates loop iteration and real-time aggregation.

---

## Core Logic
1. Declare an integer array `numbers[10]`.  
2. Initialize a Random object.  
3. Use a for loop to:
   - Assign a random integer between 1 and 100 to each array element.  
   - Add the element to a cumulative total.  
   - Print the current index, random number, and updated running total.  
4. End program execution after displaying all results.

---

## Variables
- `numbers`: Integer array of size 10.  
- `random`: Instance of Random for number generation.  
- `cumulativeTotal`: Integer accumulator for the running sum.  

---

## Build & Run

### Requirements
- .NET 6.0 SDK or newer

### Execution
From Visual Studio or a terminal:
```bash
dotnet run
