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
	public class FoodCreator
	{
		int mapWigth;
		int mapHigth;
		char sym;

		Random random = new Random ();

		public FoodCreator (int mapWigth, int mapHigth, char sym)
		{
			this.mapWigth = mapWigth;
			this.mapHigth = mapHigth;
			this.sym = sym;
		}

		public Point CreateFood()
		{
			int x = random.Next (2, mapWigth - 2);
			int y = random.Next (2, mapHigth - 2);
			return new Point (x, y, sym);
		}
	}
}

