using System;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLife
{
	public class GameState
	{
		private List<Position> _positions = new List<Position>();

		public void PutAliveCell (Position position)
		{
			_positions.Add(position);
		}

		public int AliveCells ()
		{
			return _positions.Count;
		}

		public CellState GetState (Position position)
		{
			if(_positions.Contains(position))
				return CellState.Alive;
			return CellState.Dead;
		}
	}

}

