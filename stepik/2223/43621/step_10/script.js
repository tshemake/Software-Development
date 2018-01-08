function testArray(a, b) {
    let array = ["Иванов"].concat(a.split('')).concat(b.split(''));
    return array.reverse().join('');
}