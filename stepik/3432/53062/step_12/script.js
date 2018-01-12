function testOperation(a, b) {
    var x;
    x = (a * b % (a + b)) * 3;
    return x;
}