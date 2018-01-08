function testErrorFunc(a, func) {
    try {
        func(a);
    } catch (ex) {
        var x = ex.name;
    }
    return x;
}