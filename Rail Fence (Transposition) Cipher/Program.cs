Console.WriteLine("Vernam Stream Cipher Encryption / Decryption");

Console.WriteLine("Enter message :");
string StringMessage = Console.ReadLine();
Console.WriteLine("Enter Key :");
string StringKey = Console.ReadLine();

int IntMessage = int.Parse(StringMessage);
int IntKey = int.Parse(StringKey);

//Encryption
Console.WriteLine("Encryption:");
Console.WriteLine(Convert.ToString(IntMessage, 2));
Console.WriteLine(Convert.ToString(IntKey, 2));
int cypher = IntMessage ^ IntKey;
Console.WriteLine(Convert.ToString(cypher, 2));
Console.WriteLine("-----------------------------");
Console.WriteLine("Encryption:");

Console.WriteLine(cypher);

//Decryption
Console.WriteLine("Decryption:");
int Plain = cypher ^ IntKey;
Console.WriteLine(Plain);