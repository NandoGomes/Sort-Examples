namespace Sort.Algorithms
{
	public partial class Sorter
	{
		public void CocktailSort(int[] vector)
		{
			bool sorted;

			do
			{
				sorted = true;

				for (int index = 0; index < vector.Length - 1; index++)
					if (vector[index] > vector[index + 1])
					{
						Swap(vector, index, index + 1);
						sorted = false;
					}

				if (!sorted)
				{
					sorted = true;

					for (int index = vector.Length - 1; 0 < index; index--)
						if (vector[index - 1] > vector[index])
						{
							Swap(vector, index - 1, index);
							sorted = false;
						}
				}
			} while (!sorted);
		}
	}
}