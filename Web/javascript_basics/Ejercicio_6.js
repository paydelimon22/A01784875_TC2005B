function hackerSpeak(str) {
    const hackerChars = { 'a': '4','e': '3', 'i': '1', 'o': '0', 's': '5', 't':'7'};
    return str.replace(/[aeios]/gi, char => hackerChars[char] || char);
}

console.log(hackerSpeak('Javascript'));
console.log(hackerSpeak('Hola'));
console.log(hackerSpeak('leet'));
