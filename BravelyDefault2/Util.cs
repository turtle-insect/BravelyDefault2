using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravelyDefault2
{
	class Util
	{
		public static void WriteNumber(uint address, uint size, uint value, uint min, uint max)
		{
			if (value < min) value = min;
			if (value > max) value = max;
			SaveData.Instance().WriteNumber(address, size, value);
		}

		public static GVASData ReadData(String name)
		{
			var gvas = new GVAS(null);
			var list = SaveData.Instance().FindAddress(name, 0);
			if (list.Count == 0) return null;
			gvas.AppendValue(list[0]);
			return gvas.Key(name);
		}
	}
}
