using System;

namespace GameOfLife
{
	public class GameOfLife
	{
		private GameBoard _gameBoard;

		public GameOfLife (GameSize size, GameState state)
			this._gameBoard = new GameBoard(size, state);
		}

		public GameState Next()
		{
			return new GameState(_gameBoard);
		}
	}
}

