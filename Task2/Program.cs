int GetRandNum(){
    int numRand = new Random().Next(100, 1000);
    return numRand;
}

int[] Array(){
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++){
        array[i] = GetRandNum();
    }
    return array;
}

int GetNumEvenNumbers(int[] array){
    int count = 0;
    foreach(int el in array){
    count += (el%2 == 0) ? 1: 0;
    }
    return count;
}

int rand = GetRandNum();
int[] ArrayNum = Array();
int EvenCount = GetNumEvenNumbers(ArrayNum);
Console.WriteLine(EvenCount);
