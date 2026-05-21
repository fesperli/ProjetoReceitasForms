CREATE DATABASE GerenciadorReceitasDB;
GO

USE GerenciadorReceitasDB;
GO

CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL
);

CREATE TABLE Ingredientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    UnidadeMedida NVARCHAR(50) NOT NULL
);

CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL
);

CREATE TABLE Receitas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    ModoPreparo NVARCHAR(MAX) NOT NULL,
    TempoPreparo INT NOT NULL,
    CategoriaId INT NOT NULL,
    UsuarioId INT NOT NULL,

    CONSTRAINT FK_Receitas_Categorias 
        FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id),

    CONSTRAINT FK_Receitas_Usuarios 
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

CREATE TABLE ReceitaIngredientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ReceitaId INT NOT NULL,
    IngredienteId INT NOT NULL,
    Quantidade DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_ReceitaIngredientes_Receitas 
        FOREIGN KEY (ReceitaId) REFERENCES Receitas(Id),

    CONSTRAINT FK_ReceitaIngredientes_Ingredientes 
        FOREIGN KEY (IngredienteId) REFERENCES Ingredientes(Id)
);

CREATE TABLE Avaliacoes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ReceitaId INT NOT NULL,
    UsuarioId INT NOT NULL,
    Nota INT NOT NULL,
    Comentario NVARCHAR(300),

    CONSTRAINT FK_Avaliacoes_Receitas 
        FOREIGN KEY (ReceitaId) REFERENCES Receitas(Id),

    CONSTRAINT FK_Avaliacoes_Usuarios 
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id),

    CONSTRAINT CK_Avaliacoes_Nota CHECK (Nota BETWEEN 1 AND 5)
);
GO

INSERT INTO Categorias (Nome) VALUES
('Doce'),
('Salgado'),
('Massa'),
('Bebida');

INSERT INTO Ingredientes (Nome, UnidadeMedida) VALUES
('Farinha de Trigo', 'gramas'),
('Ovo', 'unidade'),
('Leite', 'ml'),
('Açúcar', 'gramas'),
('Sal', 'gramas');

INSERT INTO Usuarios (Nome, Email) VALUES
('Felipe', 'felipe@email.com'),
('João', 'joao@email.com'),
('Maria', 'maria@email.com');

INSERT INTO Receitas (Nome, ModoPreparo, TempoPreparo, CategoriaId, UsuarioId)
VALUES
('Bolo Simples', 'Misture os ingredientes e leve ao forno por 40 minutos.', 40, 1, 1),
('Panqueca', 'Misture tudo, coloque na frigideira e doure dos dois lados.', 20, 3, 2);

INSERT INTO ReceitaIngredientes (ReceitaId, IngredienteId, Quantidade) VALUES
(1, 1, 300),
(1, 2, 3),
(1, 4, 200),
(2, 1, 200),
(2, 3, 250),
(2, 2, 2);

INSERT INTO Avaliacoes (ReceitaId, UsuarioId, Nota, Comentario) VALUES
(1, 2, 5, 'Receita muito boa.'),
(2, 1, 4, 'Fácil de fazer.');

SELECT * FROM Categorias;
SELECT * FROM Ingredientes;
SELECT * FROM Usuarios;
SELECT * FROM Receitas;
SELECT * FROM ReceitaIngredientes;
SELECT * FROM Avaliacoes;