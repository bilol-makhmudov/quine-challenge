# Quine Challenge: C# to JavaScript to C#

## Overview
This repository contains a solution to a **"mad skills" puzzle challenge**: writing a single-file C# program that generates a JavaScript file, which, when executed, outputs the original C# code. 

## Challenge Description
The task required:
1. Writing C# code that outputs valid JavaScript code.
2. The generated JavaScript code, when executed, outputs the original C# code.
3. Achieving this in a single file without reading from or writing to the file system.

## Materials that I've read to complete this task
1. https://en.wikipedia.org/wiki/Quine_(computing)
2. https://mzikmund.dev/blog/the-shortest-quine-in-csharp
3. https://www.geeksforgeeks.org/quines-in-javascript/

For verification:
- The process involves generating the JavaScript file, running it, and ensuring the output matches the original C# source code.

### Example Workflow
1. Run the C# program to generate `solution.js`:
   ```bash
   dotnet run > solution.js
   node solution.js > Program2.cs
   diff Program.cs.cs Program2.cs