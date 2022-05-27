namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			if (count < 100)
			{
				if (count == 11 || count == 12 || count == 13 || count == 14)
				{
					return "рублей";
				}
				else if (count % 10 == 1)
					return "рубль";
				else if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4)
				{
					return "рубля";
				}
				else
					return "рублей";
			}
			else
			{
				count = count % 100;
				if (count == 11 || count == 12 || count == 13 || count == 14)
				{
					return "рублей";
				}
				else if (count % 10 == 1)
					return "рубль";
				else if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4)
				{
					return "рубля";
				}
				else
					return "рублей";
			}
		}
	}
}