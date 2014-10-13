using System;
using System.Collections.Generic;

namespace smn
{
	public class SMNFunc : PartRecBase
	{
		PartRecBase e;
		int y;
		int n;

		PartRecBase internalConstructedFunc;

		//currently only operates as S1n
		public SMNFunc (PartRecBase e, int y, int n)
		{
			this.e = e;
			this.y = y;
			this.n = n;

			//construct S machine according to script
			//s1n=<4,e2-1,e,<0,e2-1,y>,<1,e2-1,1>..<1,e2-1,n-1>s

			List<PartRecBase> functionParams = new List<PartRecBase> ();

			for (int i=1; i<=n; i++) {

				functionParams.Add (PartRecFactory.GetFunction (1, e.NumParams - 1, i));
			}

			internalConstructedFunc = PartRecFactory.GetFunction (4, e.NumParams - 1, e, functionParams);

		}


		#region implemented abstract members of PartRecBase
		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
		


		}
		#endregion
	}
}

