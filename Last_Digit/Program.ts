class LastDigitPrinter {
    static main(): void {
        // Declare variables for the number and the last digit
        let n: number, lastDigit: number;

        // Read user input for the number
        console.log("Enter a number: ");
        n = parseInt(prompt("")); // Use prompt for user input in a browser environment

        // Find the last digit using the modulo operation
        lastDigit = n % 10;

        // Print the last digit
        console.log("The last digit of the number is: " + lastDigit);
    }
}

// Call the main method to start the program
LastDigitPrinter.main();
