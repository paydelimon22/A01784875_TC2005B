DROP DATABASE IF EXISTS pokemon_tcg;
CREATE DATABASE pokemon_tcg;
USE pokemon_tcg;

CREATE TABLE Jugador (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Usuario VARCHAR(100) NOT NULL UNIQUE,
    Contraseña VARCHAR(100) NOT NULL
);

CREATE TABLE Tipo (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Carta (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripción TEXT,
    Tipo INT,
    FOREIGN KEY (Tipo) REFERENCES Tipo(ID)
);

CREATE TABLE Mazo (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    id_jugador INT,
    name VARCHAR(100) NOT NULL,
    FOREIGN KEY (id_jugador) REFERENCES Jugador(ID)
);

CREATE TABLE Partida (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    id_jugador1 INT,
    id_jugador2 INT,
    id_ganador INT,
    FOREIGN KEY (id_jugador1) REFERENCES Jugador(ID),
    FOREIGN KEY (id_jugador2) REFERENCES Jugador(ID),
    FOREIGN KEY (id_ganador) REFERENCES Jugador(ID)
);

CREATE TABLE Mazo_Carta (
    id_mazo INT,
    id_carta INT,
    PRIMARY KEY (id_mazo, id_carta),
    FOREIGN KEY (id_mazo) REFERENCES Mazo(ID),
    FOREIGN KEY (id_carta) REFERENCES Carta(ID)
);
