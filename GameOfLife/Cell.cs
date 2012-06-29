using System;

namespace GameOfLife
{
	public class Cell
	{
		private Position _position;
		private CellState _cellState;

		public Cell (Position position, CellState cellState)
		{
			this._position = position;
			this._cellState = cellState;
		}
	}
}

