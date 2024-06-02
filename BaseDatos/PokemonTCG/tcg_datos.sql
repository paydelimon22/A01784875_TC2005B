INSERT INTO Tipo (Nombre) VALUES 
('Electric'),
('Water'),
('Rock'),
('Normal'),
('Fire'),
('Grass'),
('Psychic'),
('Fighting'),
('Flying'),
('Poison'),
('Ground'),
('Bug'),
('Ghost'),
('Ice'),
('Dragon');

INSERT INTO Carta (Nombre, Descripción, Tipo) VALUES 
('Pikachu', 'Electric type Pokémon', 1),
('Squirtle', 'Water type Pokémon', 2),
('Onix', 'Rock type Pokémon', 3),
('Eevee', 'Normal type Pokémon', 4),
('Charmander', 'Fire type Pokémon', 5),
('Bulbasaur', 'Grass type Pokémon', 6),
('Mewtwo', 'Psychic type Pokémon', 7),
('Machamp', 'Fighting type Pokémon', 8),
('Pidgeotto', 'Flying type Pokémon', 9),
('Ekans', 'Poison type Pokémon', 10),
('Sandshrew', 'Ground type Pokémon', 11),
('Scyther', 'Bug type Pokémon', 12),
('Gengar', 'Ghost type Pokémon', 13),
('Articuno', 'Ice type Pokémon', 14),
('Dragonite', 'Dragon type Pokémon', 15);

INSERT INTO Jugador (Nombre, Usuario, Contraseña) VALUES 
('Ash Ketchum', 'ash', 'pikachu123'),
('Misty Waterflower', 'misty', 'water123'),
('Brock Harrison', 'brock', 'rock123'),
('Gary Oak', 'gary', 'rival123'),
('Red', 'red', 'charizard123'),
('Blue', 'blue', 'blastoise123'),
('Leaf', 'leaf', 'venusaur123'),
('Jessie', 'jessie', 'teamrocket123'),
('James', 'james', 'teamrocket123'),
('Giovanni', 'giovanni', 'boss123');

INSERT INTO Mazo (id_jugador, name) VALUES 
(1, 'Electric Surge'),
(2, 'Water Splash'),
(3, 'Rock Solid'),
(4, 'Rival Deck'),
(5, 'Fire Fury'),
(6, 'Grass Greenery'),
(7, 'Psychic Power'),
(8, 'Fighting Frenzy'),
(9, 'Flying Freedom'),
(10, 'Poison Panic');

INSERT INTO Partida (id_jugador1, id_jugador2, id_ganador) VALUES 
(1, 2, 1),
(3, 4, 3),
(5, 6, 5),
(7, 8, 8),
(9, 10, 10),
(2, 3, 3),
(4, 5, 5);

INSERT INTO Mazo_Carta (id_mazo, id_carta) VALUES 
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(2, 5),
(2, 6),
(2, 7),
(2, 8),
(3, 9),
(3, 10);