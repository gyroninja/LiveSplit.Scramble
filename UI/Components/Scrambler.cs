using System;
using System.Net;

namespace LiveSplit
{
	public class Scrambler
	{
		public static String scramble() {

			using(WebClient client = new WebClient()) {
				return client.DownloadString(new Uri("http://gyroninja.net:5251/scramble")).Split(':')[1].Split('\"')[1];
			}
		}

		public static String oldScramble() {

			Random gen = new Random();

			String scramble = "";

			int lastTurn = -1;

			for (int i = 0; i < 25; i++) {

				int newTurn = gen.Next (0, 6);

				while (newTurn == lastTurn || (newTurn % 2 == 0 ? newTurn + 1 == lastTurn : newTurn - 1 == lastTurn)) {
					newTurn = gen.Next (0, 6);
				}
				lastTurn = newTurn;
				switch (newTurn) {

				case 0:

					scramble += "F";

					break;

				case 1:

					scramble += "B";

					break;

				case 2:

					scramble += "L";

					break;

				case 3:

					scramble += "R";

					break;

				case 4:

					scramble += "U";

					break;

				case 5:

					scramble += "D";

					break;
				}

				switch (gen.Next (0, 3)) {

				case 0:

					scramble += " ";

					break;

				case 1:

					scramble += "` ";

					break;

				case 2:

					scramble += "2 ";

					break;
				}
			}
			System.Console.WriteLine (scramble);

			return scramble;
		}
	}
}