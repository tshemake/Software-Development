function testRegExp(s, sub_s) {
    let array = [];
    let myPattern = new RegExp(sub_s, 'g');
    while (myPattern.test(s)) {
        array.push(sub_s);
    }
    return array.join(',');
}