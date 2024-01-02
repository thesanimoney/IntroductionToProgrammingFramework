class NthDigitPrinter {
    static main(): void {
        // Declare variables for the number, n, and the n-th digit
        let number: number, n: number, nDigit: number;

        // Read user input for the number and n
        console.log("Enter a number: ");
        number = parseInt(prompt("")); // Use prompt for user input in a browser environment

        console.log("Enter the position of the digit (n): ");
        n = parseInt(prompt(""));

        // Find the n-th digit using modular division
        let divisor: number = 10 ** (n - 1);

        if (divisor === 0 || n < 1) {
            // If n is out of range (e.g., n = 0 or n > number of digits), print a dash
            console.log("The specified position is out of range: -");
        } else {
            nDigit = Math.floor((number / divisor) % 10);
            console.log(`The ${n}-th digit from the right is: ${nDigit}`);
        }
    }
}

// Call the main method to start the program
NthDigitPrinter.main();
