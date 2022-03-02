using System;
using System.Text; 

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            
            //byte
            Console.WriteLine($"Byte:");
            Console.WriteLine($"    Max: {byte.MaxValue}");
            //Console.WriteLine($"    Overflow: {byte.MaxValue+1}");
            Console.WriteLine($"    Min: {byte.MinValue}");

            //sbyte
            Console.WriteLine($"Sbyte:");
            Console.WriteLine($"    Max: {sbyte.MaxValue}");
            //Console.WriteLine($"    Overflow: {sbyte.MaxValue+1}");
            Console.WriteLine($"    Min: {sbyte.MinValue}");

            //short
            Console.WriteLine($"Short:");
            Console.WriteLine($"    Max: {short.MaxValue}");
            //Console.WriteLine($"    Overflow: {short.MaxValue+1}");
            Console.WriteLine($"    Min: {short.MinValue}");

            //ushort
            Console.WriteLine($"Ushort:");
            Console.WriteLine($"    Max: {ushort.MaxValue}");
            //Console.WriteLine($"    Overflow: {ushort.MaxValue+1}");
            Console.WriteLine($"    Min: {ushort.MinValue}");
            
            //int
            Console.WriteLine($"Int:");
            Console.WriteLine($"    Max: {int.MaxValue}");
            //Console.WriteLine($"    Overflow: {int.MaxValue+1}");
            Console.WriteLine($"    Min: {int.MinValue}");

            //uint
            Console.WriteLine($"Uint:");
            Console.WriteLine($"    Max: {uint.MaxValue}");
            //Console.WriteLine($"    Overflow: {uint.MaxValue+1}");
            Console.WriteLine($"    Min: {uint.MinValue}");

            //long
            Console.WriteLine($"Long:");
            Console.WriteLine($"    Max: {long.MaxValue}");
            //Console.WriteLine($"    Overflow: {long.MaxValue+1}");
            Console.WriteLine($"    Min: {long.MinValue}");

            //ulong
            Console.WriteLine($"Ulong:");
            Console.WriteLine($"    Max: {ulong.MaxValue}");
            //Console.WriteLine($"    Overflow: {ulong.MaxValue+1}");
            Console.WriteLine($"    Min: {ulong.MinValue}");

            //char
            Console.WriteLine($"Char:");
            Console.WriteLine($"    Max: {char.MaxValue}");
            //Console.WriteLine($"    Overflow: {char.MaxValue+1}");
            Console.WriteLine($"    Min: {char.MinValue}");

            //float
            Console.WriteLine($"Float:");
            Console.WriteLine($"    Max: {float.MaxValue}");
            Console.WriteLine($"    Overflow1: {float.MaxValue+1}");
            Console.WriteLine($"    Overflow2: {float.MaxValue*2}");
            Console.WriteLine($"    UnderFlow: {float.MaxValue-0.000000001}");
            Console.WriteLine($"    Min: {float.MinValue}");
            Console.WriteLine($"    +{'\u221E'}: {float.PositiveInfinity}");
            Console.WriteLine($"    -{'\u221E'}: {float.NegativeInfinity}");
            Console.WriteLine($"    NaN: {float.NaN}");

            //double
            Console.WriteLine($"Double:");
            Console.WriteLine($"    Max: {double.MaxValue}");
            Console.WriteLine($"    Overflow1: {double.MaxValue+1}");
            Console.WriteLine($"    Overflow2: {double.MaxValue*2}");
            Console.WriteLine($"    UnderFlow: {double.MaxValue-0.000000001}");
            Console.WriteLine($"    Min: {double.MinValue}");
            Console.WriteLine($"    +{'\u221E'}: {double.PositiveInfinity}");
            Console.WriteLine($"    -{'\u221E'}: {double.NegativeInfinity}");
            Console.WriteLine($"    NaN: {double.NaN}");

        }
    }
}
