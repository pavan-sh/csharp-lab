
// The compiler puts top-level statements in a generated Program class.
// This partial declaration adds this method to that class.
partial class Program
{
    static void WhatsMyNamespaces()
    {
        Console.WriteLine("Namespace of class: {0}", arg0: typeof(Program).Namespace ?? "null");
    }
}