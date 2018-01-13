function testMath(a, b, c, d) {
    let max = Math.max(a, b, c, d);
    let min = Math.min(a, b, c, d);
    return Math.ceil(max / min);
}