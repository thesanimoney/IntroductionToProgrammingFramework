class DayOfWeekConverter {
    static main(): void {
        // Declare a variable for the input digit
        let n: number;

        // Read user input for the digit
        console.log("Enter a digit (1-7): ");
        n = parseInt(prompt("")); // Use prompt for user input in a browser environment

        // Initialize a variable for the day of the week
        let dayOfWeek: string;

        // Use a switch statement to determine the day of the week
        switch (n) {
            case 1:
                dayOfWeek = "Monday";
                break;
            case 2:
                dayOfWeek = "Tuesday";
                break;
            case 3:
                dayOfWeek = "Wednesday";
                break;
            case 4:
                dayOfWeek = "Thursday";
                break;
            case 5:
                dayOfWeek = "Friday";
                break;
            case 6:
                dayOfWeek = "Saturday";
                break;
            case 7:
                dayOfWeek = "Sunday";
                break;
            default:
                dayOfWeek = "not valid";
                break;
        }

        // Print the result
        console.log("Day of the week: " + dayOfWeek);
    }
}

// Call the main method to start the program
DayOfWeekConverter.main();
