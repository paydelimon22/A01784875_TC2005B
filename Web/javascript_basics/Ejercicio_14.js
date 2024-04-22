function esPotenciaDeDos(numero) {
    return (numero & (numero - 1)) === 0 && numero !== 0;
}

console.log(esPotenciaDeDos(16)); 
console.log(esPotenciaDeDos(25)); 
console.log(esPotenciaDeDos(64));