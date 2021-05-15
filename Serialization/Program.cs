using System;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binary = new BinarySerialization();
            binary.Serialization();
            BinaryDeSerialization binaryDeSerialization = new BinaryDeSerialization();
            binaryDeSerialization.DeSerialization();
        }
    }
}
