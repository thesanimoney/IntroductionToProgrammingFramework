class SignOfProduct {
    static main(): void {
        // Declare variables for three numbers and the product
        let a: number, b: number, c: number, product: number;

        // Read user input for the three numbers
        console.log("Enter the first number: ");
        a = parseFloat(prompt("")); // Use prompt for user input in a browser environment

        console.log("Enter the second number: ");
        b = parseFloat(prompt(""));

        console.log("Enter the third number: ");
        c = parseFloat(prompt(""));

        // Calculate the product of the three numbers
        product = a * b * c;

        // Determine the sign of the product using if statements
        if (this.isNegative(a) || this.isNegative(b) || this.isNegative(c)) {
            // If there are 1 or 3 negative numbers, the product is negative
            console.log("The sign of the product is: Negative");
        } else if (product === 0) {
            // If any of the numbers is zero, the product is zero
            console.log("The product is: 0");
        } else {
            // If there are 0 or 2 negative numbers, the product is positive
            console.log("The sign of the product is: Positive");
        }
    }

    // Helper method to check if a number is negative
    static isNegative(num: number): boolean {
        return num < 0;
    }
}

// Call the main method to start the program
SignOfProduct.main();
