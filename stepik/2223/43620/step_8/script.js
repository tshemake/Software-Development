function testDateTime(a, b) {
    let date1 = new Date(a);
    let date2 = new Date(b);
    let day = (date1 >= date2) ? date1.getDay() : date2.getDay();
    let dayName;
    switch (day) {
        case 0:
            dayName = "Воскресенье";
            break;
        case 1:
            dayName = "Понедельник";
            break;
        case 2:
            dayName = "Вторник";
            break;
        case 3:
            dayName = "Среда";
            break;
        case 4:
            dayName = "Четверг";
            break;
        case 5:
            dayName = "Пятница";
            break;
        case 6:
            dayName = "Суббота";
            break;
    }

    return dayName;
}