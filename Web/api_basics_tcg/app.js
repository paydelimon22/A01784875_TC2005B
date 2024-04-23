"use strict"
import express, { json } from 'express';

const app = express();
const port = 5000;
let cards = [];

/*
EJEMPLO
app.get('/', (req, res) => {
  res.send('Hello World');  
});
*/

app.use(express.json());

app.get('/show_cards', (req, res) => {
    cards.push(req.body);
    if(cards.length > 0){
        res.status(200).send("Cards retrieved successfully");
    }
    else{
        res.status(200).send("Empty Array of Cards");
    }
    console.log(cards);
});


app.listen(port, ()=>{
    console.log(`Running on port: ${port}`)
});
