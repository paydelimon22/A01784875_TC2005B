function factoriza(numero) {
    let factores = [];
    for (let i = 1; i <= numero; i++) {
        if (numero % i === 0) {
            factores.push(i);
        }
    }
    return factores;
}

console.log(factoriza(12));
console.log(factoriza(20));
console.log(factoriza(7));