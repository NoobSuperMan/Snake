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
	public class VerticalLine  : Figure
	{
		public VerticalLine (int yUp, int yDown, int x, char sym)
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++) 
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}

