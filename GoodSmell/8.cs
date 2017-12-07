DateTime dt = DateTime.Now;
char pad = '0';
Console.WriteLine("--"+dt.Hour.ToString().PadLeft(2,pad)+":"+dt.Minute.ToString().PadLeft(2,pad)+":"+dt.Second.ToString().PadLeft(2,pad)+"--");