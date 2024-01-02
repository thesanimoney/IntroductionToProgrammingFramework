class FactorialCalculator {
    static main(): void {
        // Declare variables for the input number and factorial
        let n: number;
        let factorial: number = 1; // Use number to handle larger factorials

        // Read user input for the number
        console.log("Enter a non-negative integer to calculate its factorial: ");
        n = parseInt(prompt("")); // Use prompt for user input in a browser environment

        // Check if the input is non-negative
        if (n < 0) {
            console.log("Factorial is not defined for negative numbers.");
        } else {
            // Calculate the factorial using a loop
            for (let i = 2; i <= n; i++) {
                factorial *= i;
            }

            // Print the result
            console.log(`The factorial of ${n} is: ${factorial}`);
        }
    }
}

// Call the main method to start the program
FactorialCalculator.main();
