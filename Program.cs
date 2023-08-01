int[] list=new int[3];
for (int i = 0; i<list.Length;i++)
{
    list[i]=int.Parse(Console.ReadLine());
}
System.Console.WriteLine("print array list....");
for(int e=0; e<list.Length;e++)
{
    System.Console.WriteLine(list[e]);
}