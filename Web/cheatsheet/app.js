'use strict';

import express from 'express';
import fs from "fs";

const app = express();
app.use(express.static("public"));

const port = 5500;

app.use(express.json());

app.get("/", (req,res)=>{
    const file = fs.readFileSync("public/html/index.html", "utf-8");
    res.status(200).send(file);
})

app.listen(port, ()=>{
    console.log(`Running on port ${port}`);
})
