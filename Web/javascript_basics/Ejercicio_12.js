// Devuelve la mediana y la moda de una lista de números
function medianaYModa(arr) {
    const sortedArr = arr.sort((a, b) => a - b);
    const len = arr.length;
    const mid = Math.floor(len / 2);
    const mediana = len % 2 === 0 ? (sortedArr[mid - 1] + sortedArr[mid]) / 2 : sortedArr[mid];
    
    const freqMap = {};
    arr.forEach(num => {
        freqMap[num] = (freqMap[num] || 0) + 1;
    });
    const moda = Object.keys(freqMap).reduce((a, b) => freqMap[a] > freqMap[b] ? a : b);
    
    return { mediana, moda };
}

console.log(medianaYModa([1, 1, 2, 3, 4, 5]));
console.log(medianaYModa([1, 1, 2, 2, 2, 2, 2, 3, 3, 4, 4, 4, 5, 5]));
console.log(medianaYModa([1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5])); 
