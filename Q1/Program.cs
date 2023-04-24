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
            }
        }
        int start = int.Parse(Console.ReadLine());
        int target = int.Parse(Console.ReadLine());
        bool[] visited = new bool[number+1]; 
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            int next = queue.Dequeue();
            if(visited[next])
            {
                continue;
            }
            else
            {
                visited[next] = true;
            }

            if(next == target)
            {
                break;
            }
            foreach(int i in node[next])
            {
                queue.Enqueue(i);
            }
        }
        if(visited[target])
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}