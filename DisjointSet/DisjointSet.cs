namespace DisjointSet
{
    public class DisjointSetObj
    {
        public readonly int[] arrayValue;
        public readonly int[] arrayIndex;

        public DisjointSetObj()
        {
            arrayValue = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            arrayIndex = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        }


        public int FindIndex(int value)
        {
            for (int i = 0; i < arrayIndex.Length; i++)
            {
                if (arrayIndex[i] == value)
                    return i;

            }

            return 0;
        }

        public int FindRoot(int value)
        {
            int root;
            int keyIndex = FindIndex(value);

            int keyValue = arrayValue[keyIndex];

            if (keyValue == value)
            {
              return root = value;
            }
            else
            {
             return FindRoot(keyValue);
            }

        }

        public void Union(int value1, int value2)
        {
            var root = 0;

            int keyindex1;
            int keyindex2;

            keyindex1 = FindIndex(value1);
            keyindex2 = FindIndex(value2);

            if (value1 < value2)
            {
                root = value1;

                arrayValue[keyindex2] = root;
            }
            else
            {
                root = value2;
                arrayValue[keyindex1] = root;

            }




        }

    }
}
