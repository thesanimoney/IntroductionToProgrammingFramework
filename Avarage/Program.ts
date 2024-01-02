import * as readlineSync from 'readline-sync';

class Program {
    static main(): void {
        // Declare variables for three numbers and the average
        let a: number, b: number, c: number;
        let average: number;

        // Read user input for the three numbers
        console.log("Enter the first number: ");
        a = parseInt(readlineSync.question());

        console.log("Enter the second number: ");
        b = parseInt(readlineSync.question());

        console.log("Enter the third number: ");
        c = parseInt(readlineSync.question());

        // Calculate the average
        average = (a + b + c) / 3.0;

        // Print the result
        console.log("Average: " + average);

        // Pause to keep the console window open
        readlineSync.question("Press Enter to exit...");
    }
}

// Call the main method to start the program
Program.main();
