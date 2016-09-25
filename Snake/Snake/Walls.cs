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
	public class Walls
	{
		List<Figure> wallList;

		public Walls (int mapWigth, int mapHeight)
		{
			wallList = new List<Figure> ();

			HorizontalLine upLine = new HorizontalLine (0, mapWigth - 2, 0, '#');
			HorizontalLine downLine = new HorizontalLine (0, mapWigth - 2, mapHeight - 1, '#');
			VerticalLine leftLine = new VerticalLine (1, mapHeight - 2, 0, '#');
			VerticalLine rightLine = new VerticalLine (1, mapHeight - 2, mapWigth - 2, '#');
			wallList.Add (upLine);
			wallList.Add (downLine);
			wallList.Add (leftLine);
			wallList.Add (rightLine);
		}

		internal bool IsHit (Figure figure)
		{
			foreach (var wall in wallList)
			{
				if(wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw ()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}

