"use strict";

import express from "express";
import fs from "fs";

const app = express();
app.use(express.static("public"));
const port = 5000;

app.get("/", (req, res)=>{
    const file = fs.readFileSync("public/html/index.html", "utf8");
    res.status(200).send(file);
})

app.listen(port, () =>{
    console.log(`Client succesfully running on port: ${port}`);
})
