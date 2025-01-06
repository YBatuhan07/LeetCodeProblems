namespace PascalsTriangle;

public class Program
{
    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> list = new List<IList<int>>();

        if (numRows == 0) return list;

        list.Add(new List<int>() { 1 });

        for(int i = 1; i < numRows; i++)
        {
            List<int> row = (List<int>)list[i - 1];
            List<int> nextRow = new List<int> { 1 };

            for (int j = 1; j < row.Count; j++)
            {
                nextRow.Add(row[j - 1] + row[j]);
            }

            nextRow.Add(1);
            list.Add(nextRow);
        }
        return list;

    }
    static void Main(string[] args)
    {
        var result = Generate(5);
    }
}
