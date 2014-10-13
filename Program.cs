using System;
using System.Collections.Generic;
using System.Text;

namespace smn
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int p = 1;
			int q = 0;
			int r = 7;
			int s = 7;

			//Console.WriteLine ("p={0},q={1},r={2},s={3}", p, q, r, s);


			Console.WriteLine ("Discriminator with 4 args:");

			var disc = PartRecFactory.GetFunction (3, 0);


			for (int i=-2; i<=2; i++) {
				var parameters = new System.Collections.Generic.List<int> () { p, q, r, s+i };
				int res = disc.Execute (parameters);
				Console.WriteLine ("{{{0}}}{1} = {2}", disc.ToString (), IntListToString (parameters), res);


			}


			Console.WriteLine ("Discrimator with 3 args:");

			var disc2 =  PartRecFactory.ApplySN1 (disc,1, 4);

			for (int i=-2; i<=2; i++) {
				var parameters = new System.Collections.Generic.List<int> () { q, r, s+i};
				int res = disc2.Execute (parameters);
				Console.WriteLine ("{{{0}}}{1} = {2}", disc2.ToString (), IntListToString (parameters), res);

			}

			Console.WriteLine ("Discrimator with 2 args:");

			var disc3 =  PartRecFactory.ApplySN1 (disc2,0, 3);

			for (int i=-2; i<=2; i++) {
				var parameters = new System.Collections.Generic.List<int> () { r, s+i};
				int res = disc3.Execute (parameters);
				Console.WriteLine ("{{{0}}}{1} = {2}", disc3.ToString (), IntListToString (parameters), res);

			}

			Console.WriteLine ("Discrimator with 1 args:");

			var disc4 =  PartRecFactory.ApplySN1 (disc3,7, 2);

			for (int i=-2; i<=2; i++) {
				var parameters = new System.Collections.Generic.List<int> () { s+i};
				int res = disc4.Execute (parameters);
				Console.WriteLine ("{{{0}}}{1} = {2}", disc4.ToString (), IntListToString (parameters), res);

			}
		}

		private static string IntListToString(List<int> list)
		{
			StringBuilder bldr = new StringBuilder ();
			bldr.Append ("(");
			bldr.Append (String.Join (",", list.ToArray ()));
			bldr.Append (")");
			return bldr.ToString ();

		}

	}
}
