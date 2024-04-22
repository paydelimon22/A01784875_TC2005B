function divisorComun(a, b) {
    while (b !== 0) {
        const temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}


console.log(divisorComun(12, 8));
console.log(divisorComun(17, 5));
console.log(divisorComun(24, 36));