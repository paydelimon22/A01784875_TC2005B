'use strict';

import express from 'express';

const app = express();

const port = 5000;

app.use(express.json());


let card_list = [];


app.post("/add_card", (req, res) => {
    const newCard = req.body;
    if (!(isValidCard(newCard))) {
        return res.status(400).json({ error: "Invalid card format" });
    }
    if (cardExists(newCard.id)) {
        return res.status(409).json({ error: "Card already exists" });
    }
    card_list.push(newCard);
    res.status(201).json({ message: "Card added successfully" });
});


app.get("/show_cards", (req, res) => {
    if (card_list.length === 0) {
        return res.status(404).json({ message: "No cards available" });
    }
    res.status(200).json(card_list);
});


app.get("/show_card/:id", (req, res) => {
    const cardId = req.params.id;
    const card = card_list.find(card => card.id === cardId);
    if (!card) {
        return res.status(404).json({ message: "Card not found" });
    }
    res.status(200).json(card);
});


app.delete("/delete_card/:id", (req, res) => {
    const cardId = req.params.id;
    const index = card_list.findIndex(card => card.id === cardId);
    if (index === -1) {
        return res.status(404).json({ message: "Card not found" });
    }
    card_list.splice(index, 1);
    res.status(200).json({ message: "Card deleted successfully" });
});


app.put("/update_card/:id", (req, res) => {
    const cardId = req.params.id;
    const updatedFields = req.body;
    const index = card_list.findIndex(card => card.id === cardId);
    if (index === -1) {
        return res.status(404).json({ message: "Card not found" });
    }
    Object.assign(card_list[index], updatedFields);
    res.status(200).json({ message: "Card updated successfully" });
});


function isValidCard(card) {
    return card.hasOwnProperty('id') && card.hasOwnProperty('name') && card.hasOwnProperty('health') && card.hasOwnProperty('ability');
}

function cardExists(cardId) {
    return card_list.some(card => card.id === cardId);
}

app.listen(port, () => {
    console.log(`Running on port ${port}`);
});
