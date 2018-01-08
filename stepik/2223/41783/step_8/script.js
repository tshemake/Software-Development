function testWhile(a) {
    var x = 0;
    while (a > 0) {
        if (a % 2 == 0) {
            x += a;
        }
        a--;
    }
    return x;
}