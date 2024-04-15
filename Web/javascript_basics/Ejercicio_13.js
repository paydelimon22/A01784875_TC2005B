function cadenaMasFrecuente(arr) {
    const freqMap = {};
    arr.forEach(str => {
        freqMap[str] = (freqMap[str] || 0) + 1;
    });
    return Object.keys(freqMap).reduce((a, b) => freqMap[a] > freqMap[b] ? a : b);
}

console.log(cadenaMasFrecuente(['apple', 'banana', 'apple', 'cherry', 'cherry', 'apple'])); 
console.log(cadenaMasFrecuente(['hello', 'world', 'hello', 'hello', 'world'])); 
console.log(cadenaMasFrecuente(['f', 'b', 'f', 'f', 'b', 'b'])); 
