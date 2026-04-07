Queue<string> fila = new Queue<string>();

fila.Enqueue("João");
fila.Enqueue("Maria");
fila.Enqueue("Pedro");

Console.WriteLine(fila.Dequeue());
Console.WriteLine(fila.Dequeue());
Console.WriteLine(fila.Dequeue());
