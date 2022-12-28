string[] filterStrLength(string[] array, int max){
    int length = array.Length,
        index = 0;
    string[] result = new string[length];
    for (int i = 0; i < length; i++){
        if(array[i].Length <= max){
            result[index] = array[i];
            index += 1;
        }
    }
    Array.Resize(ref result, index);
    return result;
}

int getMaxValue(){
    Console.Write("\nВведите максимальную длину строи для фильтрации массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    return max;
}

void printArray(string[] array){
    Console.Write("[");
    int length = array.Length;
	for(int i = 0; i < length; i++){
        Console.Write($"\"{array[i]}\"");
        if(i + 1 != length) Console.Write(", ");
	}
    Console.Write("]\n");
}

string[] createArrayRandSrt(int max, int length){
    string[] simbols = new string[]{"а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т",
                                    "у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я","0","1","2","3","4","5","6",
                                    "7","8","9","-"," "},
        arrayStr = new string[length];
    string word = String.Empty;
    int index = 0,
        wordLength = 0;
    for (int i = 0; i < length; i++){
        word = "";
        wordLength = new Random().Next(1, max + 1);
        for (int j = 0; j < wordLength; j++){
            index = new Random().Next(0, simbols.Length);
            word += simbols[index];
        }
        arrayStr[i] = word;
    }
    return arrayStr;
}

int aiMaxStr = 9,
    aiLength = 13;
string[] arrayInput  = createArrayRandSrt(aiMaxStr, aiLength);
Console.WriteLine("Первоначальный массив:");
printArray(arrayInput);
int maxLengthStr = getMaxValue();
string[] arrayResult = filterStrLength(arrayInput, maxLengthStr);
Console.Write("Результат: ");
printArray(arrayResult);
