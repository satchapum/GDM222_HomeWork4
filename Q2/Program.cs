class Program 
{
    public static void Main(string[] Args)
    {
        int number = int.Parse(Console.ReadLine());
        List<List<int>> node = new List<List<int>>();  
        for(int i = 0; i < number; i++)
        {
            List<int> edgeTemp = new List<int>();
            node.Add(edgeTemp);
        }
        while(true)
        {
            int inputnode = int.Parse(Console.ReadLine());
            
            if(inputnode < 0 || inputnode >= number)
            {
                break;
            }
            else
            {
                int inputedge = int.Parse(Console.ReadLine());
                node[inputnode].Add(inputedge);
                node[inputedge].Add(inputnode);
            }
        }

        int[] color = new int[number+1]; 

        for(int i = 0; i < number; i++)
        {
            foreach(int x in node[i])
            {
                if(color[i] == color[x])
                {
                    color[x]++;
                }
            }
        }
        int temp = 0;
        foreach(int x in color)
        {
            if(x > temp)
            {
                temp = x;
            }
        }
        Console.WriteLine(temp + 1);
    }
}