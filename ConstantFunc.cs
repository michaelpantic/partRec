using System;

namespace smn
{
	public class ConstantFunc : PartRecBase
	{
		public ConstantFunc (int indexParam)
		{
			this.indexParameter = indexParam;
			this.index = 0;
		}

		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
			return indexParameter;
		}
	}
}

