function ordenDescendente(arr) {
    return arr.slice().sort((a, b) => b - a);
}

console.log(ordenDescendente([5, 3, 9, 2, 1])); 
console.log(ordenDescendente([10, 8, 6, 4, 2]));
console.log(ordenDescendente([1, 3, 2, 5, 4]));