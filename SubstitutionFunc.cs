using System;
using System.Collections.Generic;
using System.Linq;

namespace smn
{
	public class SubstitutionFunc : PartRecBase
	{
		List<PartRecBase> cn;
		PartRecBase b;

		public SubstitutionFunc(PartRecBase b, List<PartRecBase> cn)
		{
			//<4,n,b,c1...ck>
			//additionalIndexParameter
			this.index = 4;
			this.cn = cn;
			this.b = b;

		}


		#region implemented abstract members of PartRecBase

		public override int Execute (System.Collections.Generic.List<int> parameters)
		{
			var qn = new List<int> ();

			foreach (PartRecBase c in cn) {
				//execute all c's on the parameters
				qn.Add (c.Execute (parameters));
			}

			//execute b with qn as parameter
			return b.Execute (qn);
		}

		#endregion

		public override string ToString()
		{
			var simFunctionsString = String.Join (",", cn.Select (x => x.ToString ()));
		
			var indexString = string.Format ("<{0},{1},{2},{3}>",index, numParams, this.b.ToString(), simFunctionsString);

			return indexString;
		}




	}
}

