function testArray(a, b) {
    let array = ["Ivanova"].concat(a.split('')).concat(b.split(''));
    return array.reverse().join('');
}