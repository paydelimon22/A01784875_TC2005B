function capitalizeWords(str) {
    return str.split(" ").map(word => {
        return word.charAt(0).toUpperCase() + word.slice(1);
    }).join(" ");
}


console.log(capitalizeWords('javascript is fun'));
console.log(capitalizeWords('hello world')); 
console.log(capitalizeWords('the quick brown fox')); 
