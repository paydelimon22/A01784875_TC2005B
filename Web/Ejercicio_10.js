function esPalindromo(str) {
    return str === str.split('').reverse().join('');
}

console.log(esPalindromo('radar'));
console.log(esPalindromo('hello'));
console.log(esPalindromo('computadora'));
