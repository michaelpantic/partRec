using System;
using System.Collections.Generic;

namespace smn
{
	public class PartRecAdd: PartRecBase
	{
		public PartRecAdd ()
		{
			this.numParams = 2;
			this.index = 99;
		}


	
		#region implemented abstract members of PartRecBase
		public override int Execute (List<int> parameters)
		{
			if (parameters [0] == 0) {
				var projection = PartRecFactory.GetFunction (1, 1, 1);
				return projection.Execute(new List<int>(){parameters [1]}); //return projection of x to x
			} else {
					var successor = PartRecFactory.GetFunction(2,1,1);
				var projection = PartRecFactory.GetFunction (1, 3, 1);
				return successor.Execute (
					new List<int> () {

					projection.Execute(

						new List<int> () {

						Execute(new List<int>(){parameters[0]-1, parameters[1]}),
						parameters[1],
						parameters[0]-1
						}
					)
				}
				);

			}
		}
		#endregion
	}
}

