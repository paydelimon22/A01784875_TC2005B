function primerNoRepetido(cadena) {
    const countMap = {};
    for (let char of cadena) {
        countMap[char] = (countMap[char] || 0) + 1;
    }
    for (let char of cadena) {
        if (countMap[char] === 1) {
            return char;
        }
    }
    return null;
}


console.log(primerNoRepetido('abacddbec'));
console.log(primerNoRepetido('aabbccddeeff')); 
console.log(primerNoRepetido('abdefaab')); 
