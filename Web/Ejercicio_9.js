function longitudCadenaMasCorta(arr) {
    if (arr.length === 0) {
        return 0; 
    }

    let minLength = arr[0].length; 
    for (let i = 1; i < arr.length; i++) {
        const currentLength = arr[i].length;
        if (currentLength < minLength) {
            minLength = currentLength;
        }
    }
    return minLength;
}

console.log(longitudCadenaMasCorta(['bbbbb', 'dd', 'f', 'ccc']));
console.log(longitudCadenaMasCorta(['a', 'bb', 'ccc', 'dddd'])); 
console.log(longitudCadenaMasCorta(['eeee', 'hhh', 'aaaa'])); 