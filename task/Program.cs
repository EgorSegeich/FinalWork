string [] Array = {"hellow", "my", "frind", "how", "are", "you?"};

void ShowArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

string[] CheckArray(string[] array) {   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++) {
        if (array[j].Length <= 3) {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}

System.Console.Write("Строки, длина котортых мельше или равна 3: ");
ShowArray(CheckArray(Array));