int GetRandNum(){
    int numRand = new Random().Next(-100, 100);
    return numRand;
}

int[] Array(){
    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++){
        array[i] = GetRandNum();
    }
    return array;
}

int SumOddNum(int[] array){
    int SumOdd = 0;
    for(int i = 1; i <= array.Length; i+=2){
        SumOdd += array[i];
    }
    return SumOdd;
}

int rand = GetRandNum();
int[] ArrayNum = Array();
int SumOddNumber = SumOddNum(ArrayNum);
Console.WriteLine($"[{string.Join(", ", ArrayNum)}]");
Console.WriteLine($"Sum odd numbers => {SumOddNumber}");