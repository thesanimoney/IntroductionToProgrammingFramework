class DivisibilityCheck {
    static main(): void {
        // Declare variables for the number and result
        let n: number;
        let result: boolean;

        // Test cases
        let values: number[] = [121, 1263, 26, 23, 81, 1287];

        // Loop through the test cases and check divisibility
        for (let value of values) {
            n = value;

            // Check if the number is divisible by 9, 11, or 13
            result = (n % 9 === 0) || (n % 11 === 0) || (n % 13 === 0);

            // Print the result for each test case
            console.log(`${n} is divisible by 9, 11, or 13: ${result}`);
        }
    }
}

// Call the main method to start the program
DivisibilityCheck.main();
