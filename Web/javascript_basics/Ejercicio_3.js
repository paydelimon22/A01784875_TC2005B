function invertirArregloNuevo(arr) {
    const nuevoArreglo = [];
    for (let i = arr.length - 1; i >= 0; i--) {
        nuevoArreglo.push(arr[i]);
    }
    return nuevoArreglo;
}

function invertirArregloModificado(arr) {
    const len = arr.length;
    for (let i = 0; i < Math.floor(len / 2); i++) {
        const temp = arr[i];
        arr[i] = arr[len - 1 - i];
        arr[len - 1 - i] = temp;
    }
}


const arregloOriginal = [1, 2, 3, 4, 5];
console.log("Arreglo Original:", arregloOriginal); 
const nuevoArreglo = invertirArregloNuevo(arregloOriginal);
console.log("Nuevo arreglo invertido:", nuevoArreglo); 

const arregloOriginal2 = [9, 4, 2, 13, 7];
console.log("Arreglo Original:", arregloOriginal2); 
const nuevoArreglo2 = invertirArregloNuevo(arregloOriginal2);
console.log("Nuevo arreglo invertido:", nuevoArreglo2); 
