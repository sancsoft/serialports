using System.IO.Ports;

Console.WriteLine("Serial Ports:");
string[] ports = SerialPort.GetPortNames();

foreach (string port in ports)
{
    Console.Write($"{port}: ");
    try
    {
        SerialPort sp = new SerialPort(port, 9600);
        sp.Open();
        sp.Close();
        Console.WriteLine("Available");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("In Use");
    }
    catch
    {
        Console.WriteLine("Error");
    }
}

if (ports.Length == 0)
{
    Console.WriteLine("None");
}

