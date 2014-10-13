using System;

namespace smn
{
	public class DiscrimatorFunc: PartRecBase
	{
		public DiscrimatorFunc ()
		{
			this.index = 3;
		}


		#region implemented abstract members of PartRecBase

		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
			if (parameters [2] == parameters [3]) {
				return parameters [0];
			} else {
			
				return parameters [1];
			}

		}

		#endregion
	}
}

