function testFactorial(a) {
    var x = 1;
    for (let i = 1; i <= a; i++)
    {
        x *= i;
    }
    return x;
}