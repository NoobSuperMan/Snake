//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public class Snake: Figure
	{
		Direction direction;

		public Snake (Point tail, int length, Direction _direction)
		{
			direction = _direction;
			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point (tail);
				p.Move(i, direction);
				pList.Add(p);

			}
		}

		public void Move ()
		{
			Point tail = pList.First ();
			pList.Remove (tail);
			Point head =getNextPoint ();
			pList.Add (head);

			tail.Clear ();
			head.Draw ();
		}

		public Point getNextPoint()
		{
			Point head = pList.Last ();
			Point nextPoint = new Point (head);
			nextPoint.Move (1, direction);
				return nextPoint;
		}

		public void HandleKey (ConsoleKey key)
		{
			if( key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if( key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if( key == ConsoleKey.UpArrow)
				direction = Direction.UP;
			else if( key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
		}
	}
}

