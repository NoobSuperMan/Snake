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
		public Snake (Point tail, int length, Direction direction)
		{
			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point (tail);
				p.Move(i, direction);
				pList.Add(p);

			}

		}
	}
}
