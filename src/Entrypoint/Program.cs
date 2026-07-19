using Entrypoint.Arrays._01_CustomList;

var holdings = new CustomizedList<string>(2); // uma capacidade de espa;o pequena para forcar a ativacao do metodo Grow()

holdings.Add("AAPL");
holdings.Add("MSFT");
holdings.Add("GOOGL"); // nesta linha vai ativar o metodo Grow.

for (int i = 0; i < holdings.Count; i++)
    Console.WriteLine(holdings.Get(i));

holdings.RemoveAt(1);
