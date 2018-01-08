function testOperation(a, b) {
    var x;
    x = (a * b % (a + b)) * 2;
    return x;
}