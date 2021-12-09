namespace CodecNS
{
    public class Codec
    {
        public static void Main(string[] args)
        {
            string test_string = "This is a test string";
            if (String.Equals(test_string, CodecLibrary.decode(CodecLibrary.encode(test_string))))
            {
                Console.WriteLine("Test succeeded");
                Console.ReadLine();
            }
            Console.WriteLine("Test failed");
        }
    }
}