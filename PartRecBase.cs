using System;
using System.Collections.Generic;

namespace smn
{
	public abstract class PartRecBase
	{
		protected int index; // <e,n,1> => e
		protected int numParams; //<e,n,1> => n
		protected int indexParameter; //<e,n,1> => 1

		public int Index
		{
			get{return index;}
		}
		public int NumParams
		{
			get{ return numParams;}
			set{ numParams = value;}
		}
		public PartRecBase ()
		{
		}

		public abstract int Execute(List<int> parameters);

		public override string ToString ()
		{
			return string.Format ("<{0},{1},{2}>",index, numParams, indexParameter);
		}
	}
}

