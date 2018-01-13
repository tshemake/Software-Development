function testDateTime(a, b) {
    let date1 = new Date(a);
    let date2 = new Date(b);
    let day = (date1 >= date2) ? date1.getDay() : date2.getDay();
    let dayName;
    switch (day) {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
    }

    return dayName;
}