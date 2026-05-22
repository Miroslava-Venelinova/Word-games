CREATE DATABASE DBWordGames;
GO

USE DBWordGames;
GO

CREATE TABLE Players(
player_id INT IDENTITY(1,1) PRIMARY KEY,
player_username NVARCHAR(20) NOT NULL, 
player_password NVARCHAR(20) NOT NULL, 
player_totalGames INT NOT NULL, 
player_hangman_wins INT NOT NULL, 
player_wordl_wins INT NOT NULL
)

CREATE TABLE Admins(
admin_id INT IDENTITY(1,1) PRIMARY KEY, 
admin_username NVARCHAR(20) NOT NULL, 
admin_password NVARCHAR(20) NOT NULL
)

CREATE TABLE WordsHangman(
word_id INT IDENTITY(1,1) PRIMARY KEY, 
word NVARCHAR(100) NOT NULL,
word_level NVARCHAR(10) NOT NULL
)

CREATE TABLE WordsWordl(
word_id INT IDENTITY(1,1) PRIMARY KEY, 
word NVARCHAR(10) NOT NULL,
)
