CREATE TABLE Pupils (
    Id SERIAL PRIMARY KEY,
    Name TEXT, 
    Dob VARCHAR,
    Avatar TEXT
);

INSERT INTO
    Pupils (Name, Dob, Avatar)
VALUES
    ('Everly', '11/09/2015', 'https://img.favpng.com/5/2/3/computer-icons-scalable-vector-graphics-avatar-emoticon-png-favpng-209NAXaV1ZBQdYGrU7nNbMxpX.jpg'),
    ('Tommy', '29/06/2016', 'https://cdn3.iconfinder.com/data/icons/avatars-9/145/Avatar_Penguin-512.png'),
    ('Maisie', '02/12/2015', 'https://cdn3.iconfinder.com/data/icons/avatars-9/145/Avatar_Rabbit-512.png');