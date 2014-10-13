using System;

namespace smn
{
	public class SuccessorFunc : PartRecBase
	{
		int i;
		public SuccessorFunc (int indexParam)
		{
			this.index = 2;
			i = indexParam;

		}

		#region implemented abstract members of PartRecBase

		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
			return parameters [i-1] + 1;
		}

		#endregion
	}
}

