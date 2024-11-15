namespace c { class P { static void Main()
{
var s2 = @";Console.Write($_process.stdout.write(\u0060namespace c {{ class P {{ static void Main()\n{{\nvar s2 = @\u0022{s2}\u0022{s2.Replace((char)95, '_')}\u0060)_.Replace(@_\_, @_\\_));
}}}";Console.Write($"process.stdout.write(\u0060namespace c {{ class P {{ static void Main()\n{{\nvar s2 = @\u0022{s2}\u0022{s2.Replace((char)95, '"')}\u0060)".Replace(@"\", @"\\"));
}}}