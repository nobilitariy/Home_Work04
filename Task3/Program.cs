
double RandomNumber(){
    Random rand = new Random();
    int numFact = rand.Next(1, 101);
    double numRandom = rand.NextDouble() * numFact;
    double numRand = Math.Round(numRandom, 3);
    return numRand;
}

double[] Mass(){
    double[] mass = new double[5];
    for(int i = 0; i < mass.Length; i++){
        mass[i] = RandomNumber();
    }
    return mass;
}

(double minNum, double maxNum) ComMinMaxMass(double[] Mass){
    double max = Mass[0];
    double min = Mass[0];
    foreach(double el in Mass){
       max = el > max ? el : max;
       min = el < min ? el : min;
    }
    return (min, max); 
}

double SendDiff((double minNum, double maxNum) ElTuple){
    double MaxNum = ElTuple.maxNum;
    double MinNum = ElTuple.minNum;
    int WholePart = (int) MaxNum;
    int WholePart2 = (int) MinNum;
    double diffFract = ((MaxNum - WholePart)-(MinNum - WholePart2));
    double diffFractFinish = Math.Round(diffFract, 3);
    return diffFractFinish;

}

double numRand = RandomNumber();
double[] RandMass = Mass();
Console.WriteLine($"Array of random real numbers from 1 to 100 => [{string.Join(", ", RandMass)}]");
var MinMax = ComMinMaxMass(RandMass);
double DifferenceFract = SendDiff(MinMax);
Console.WriteLine($"The result of the difference between the fraction part of the maximum and minumum number of the array {DifferenceFract}");
//Console.WriteLine(numRand);

