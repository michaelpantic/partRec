using System;
using System.Collections.Generic;

namespace smn
{
	public class PartRecFactory
	{
		public PartRecFactory ()
		{
		}

		public static PartRecBase GetFunction(int index, int numParams, object addParam1=null, object addParam2=null)
		{
			if (index == 0) {
				var func = new ConstantFunc ((int)addParam1);
				func.NumParams = numParams;
				return func;
			} else if (index == 1) {
				var func = new ProjectionFunc ((int)addParam1);
				func.NumParams = numParams;
				return func;
			} else if (index == 2) {
				var func = new SuccessorFunc ((int)addParam1);
				func.NumParams = numParams;
				return func;
				
			} else if (index == 3) {
				var func = new DiscrimatorFunc ();
				func.NumParams = numParams + 4;
				return func;
				
			}else if (index == 4) {
				var func = new SubstitutionFunc ((PartRecBase)addParam1, (List<PartRecBase>)addParam2);
				func.NumParams = numParams;
				return func;
			}

			throw new Exception ("Index not defined");
		}

		public static PartRecBase ApplySN1(PartRecBase e, int y, int n)
		{
			
			List<PartRecBase> functionParams = new List<PartRecBase> ();

			functionParams.Add(PartRecFactory.GetFunction(0,e.NumParams-1,y));
			for (int i=1; i<=n-1; i++) {

				functionParams.Add (PartRecFactory.GetFunction (1, e.NumParams - 1, i));
			}

			//construct <4,e2-1,e, <0,e2-1,y>,<1,e2-1,1>...>
			return PartRecFactory.GetFunction (4, e.NumParams - 1, e, functionParams);
		}
	}
}

