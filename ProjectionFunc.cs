using System;

namespace smn
{
	public class ProjectionFunc : PartRecBase
	{

		public ProjectionFunc (int indexParam)
		{
			this.index = 1;
			this.indexParameter = indexParam;
		}	

		#region implemented abstract members of PartRecBase

		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
			//return the value at position "indexparam" = <1,num,indexparam>
			return parameters [indexParameter-1];
		}

		#endregion


	}
}

