string [] Array = {"hellow", "my", "friend", "how", "are", "you?"};
string [] finalArray = new string[6];
System.Console.Write("Строки, длина котортых мельше или равна 3: ");
for (int i = 0; i < Array.Length; i++) 
{
    if (Array[i].Length <= 3) 
    {
        finalArray[i] = Array[i];
        Console.Write(finalArray[i] + ", ");
    }
}