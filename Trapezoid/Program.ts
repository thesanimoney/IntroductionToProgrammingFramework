class TrapezoidAreaCalculator {
    static main(): void {
        // Declare variables for base sides and height
        let a: number, b: number, h: number, area: number;

        // Read user input for the base sides and height
        console.log("Enter the length of base side 'a': ");
        a = parseFloat(prompt("")); // Use prompt for user input in a browser environment

        console.log("Enter the length of base side 'b': ");
        b = parseFloat(prompt(""));

        console.log("Enter the height 'h': ");
        h = parseFloat(prompt(""));

        // Calculate the area of the trapezoid
        area = 0.5 * (a + b) * h;

        // Print the result
        console.log("The area of the trapezoid is: " + area);
    }
}

// Call the main method to start the program
TrapezoidAreaCalculator.main();
