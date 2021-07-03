namespace Sort.Algorithms
{
	public partial class Sorter
	{
		public void OddEvenSort(int[] vector)
		{
			bool sorted;

			do
			{
				sorted = true;

				for (int index = 0; index < vector.Length - 1; index += 2)
					if (vector[index] > vector[index + 1])
					{
						Swap(vector, index, index + 1);
						sorted = false;
					}

				for (int index = 1; index < vector.Length - 1; index += 2)
					if (vector[index] > vector[index + 1])
					{
						Swap(vector, index, index + 1);
						sorted = false;
					}
			} while (!sorted);
		}
	}
}