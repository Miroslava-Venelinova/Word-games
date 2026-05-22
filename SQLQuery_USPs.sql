CREATE OR ALTER PROC usp_AddPlayer
	@player_username NVARCHAR(20), @player_password NVARCHAR(20), 
	@player_total_games INT, @player_hangman_wins INT, @player_wordl_wins INT
AS
	INSERT INTO Players
	VALUES(@player_username, @player_password, @player_total_games, 
		@player_hangman_wins, @player_wordl_wins)
GO

CREATE OR ALTER PROC usp_AddAdmin
	@admin_username NVARCHAR(20), @admin_password NVARCHAR(20)
AS
	INSERT INTO Admins
	VALUES(@admin_username, @admin_password)
GO

CREATE OR ALTER PROC usp_AddWordHangman
	@word NVARCHAR(100), @word_level NVARCHAR(20)
AS
	INSERT INTO WordsHangman
	VALUES(@word, @word_level)
GO

CREATE OR ALTER PROC usp_AddWordWordl
	@word NVARCHAR(10)
AS
	INSERT INTO WordsWordl
	VALUES(@word)
GO
