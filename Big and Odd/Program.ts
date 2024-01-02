class NumberCheck {
    static main(): void {
        // Declare variables for the number and result
        let n: number;
        let result: boolean;

        // Read user input for the number
        console.log("Enter a number: ");
        n = parseInt(prompt("")); // Use prompt for user input in a browser environment

        // Check if the number is greater than 20 and odd
        result = (n > 20) && (n % 2 === 1);

        // Print the result
        console.log("Is the number greater than 20 and odd? " + result);
    }
}

// Call the main method to start the program
NumberCheck.main();
