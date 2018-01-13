function testArray(a, b) {
    let sum = 0;
    for (let i in a) {
        sum += a[i];
    }
    for (let i in b) {
        sum += b[i];
    }
    return sum * sum;
}