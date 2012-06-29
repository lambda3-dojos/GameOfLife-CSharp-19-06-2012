using System;
using NUnit.Framework;

namespace GameOfLife.Test
{
	[TestFixture()]
	public class Test
	{
		[Test]
		public void It_should_accept_an_initial_state_for_the_board()
		{
			var initialState = new GameState();
			initialState.PutAliveCell(new Position(0,0));

			Assert.AreEqual(1, initialState.AliveCells());
		}

		[Test]
		public void It_should_accept_two_alive_cells_and_return()
		{
			var initialState = new GameState();
			initialState.PutAliveCell(new Position(0,0));
			initialState.PutAliveCell(new Position(1,1));

			Assert.AreEqual(2, initialState.AliveCells());
		}

		[Test]
		public void It_should_kill_an_alone_alive_cell()
		{
			var initialState = new GameState();
			initialState.PutAliveCell(new Position(0,0));

			var size = new GameSize(3,3);
			var game = new GameOfLife(size, initialState);

			var currentState = game.Next();

			Assert.AreEqual(0, currentState.AliveCells());
			Assert.AreEqual(CellState.Dead, currentState.GetState(new Position(0,0)));
		}

		[Test]
		public void It_should_keeps_alive_cell_when_there_is_two_neighbors()
		{
			var initialState = new GameState();
			initialState.PutAliveCell(new Position(0,0));
			initialState.PutAliveCell(new Position(1,0));
			initialState.PutAliveCell(new Position(0,1));

			var size = new GameSize(3,3);
			var game = new GameOfLife(size, initialState);

			var currentState = game.Next();

			Assert.AreEqual(CellState.Alive, currentState.GetState(new Position(0,0)));
		}
	}
}

