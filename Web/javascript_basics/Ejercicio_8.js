function quitaDuplicados(arr) {
    return arr.filter((element, index) => arr.indexOf(element) === index);
}


console.log(quitaDuplicados([1, 0, 1, 1, 0, 0]));
console.log(quitaDuplicados([5, 5, 5, 5, 5])); 
console.log(quitaDuplicados([1, 2, 3, 4, 5])); 
