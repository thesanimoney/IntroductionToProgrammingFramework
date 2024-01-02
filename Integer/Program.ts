class Program {
    static main(): void {
        // Using suitable variable types for each value
        let value1: number = -100; // TypeScript uses number for signed 8-bit integers
        let value2: number = 128; // TypeScript uses number for unsigned 8-bit integers
        let value3: number = -3540;
        let value4: number = 64876;
        let value5: bigint = 2147483648n; // Use bigint to hold the value
        let value6: bigint = -1141583228n;
        let value7: bigint = -1223372036854775808n;

        // Printing the values to the console
        console.log("Value 1: " + value1);
        console.log("Value 2: " + value2);
        console.log("Value 3: " + value3);
        console.log("Value 4: " + value4);
        console.log("Value 5: " + value5);
        console.log("Value 6: " + value6);
        console.log("Value 7: " + value7);
    }
}

// Call the main method to start the program
Program.main();
