function bubbleSort(arr) {
    let len = arr.length;
    for (let i = 0; i < len; i++) {
        for (let j = 0; j < len - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                let temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}

console.log(bubbleSort([52, 31, 89, 27, 15])); 
console.log(bubbleSort([10, 8, 6, 4, 2]));
console.log(bubbleSort([1, 3, 2, 5, 4])); 
