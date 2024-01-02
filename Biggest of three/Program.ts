class BiggestNumberFinder {
    static main(): void {
        // Declare variables for three numbers
        let a: number, b: number, c: number;

        // Read user input for the three numbers
        console.log("Enter the first number: ");
        a = parseInt(prompt("")); // Use prompt for user input in a browser environment

        console.log("Enter the second number: ");
        b = parseInt(prompt(""));

        console.log("Enter the third number: ");
        c = parseInt(prompt(""));

        // Find the biggest number using conditional if statements
        let biggestNumber: number = a; // Assume the first number is the biggest

        if (b > biggestNumber) {
            biggestNumber = b; // Update if the second number is bigger
        }

        if (c > biggestNumber) {
            biggestNumber = c; // Update if the third number is bigger
        }

        // Print the result
        console.log("The biggest number is: " + biggestNumber);
    }
}

// Call the main method to start the program
BiggestNumberFinder.main();
