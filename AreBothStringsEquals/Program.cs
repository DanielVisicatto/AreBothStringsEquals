string firstString, secondString;
GetData();
UserAnswer();


bool CompareStrings(string x, string y)
{
    if (x.Equals(y)) return true;
    else return false;      
}
void GetData()
{
    Console.WriteLine("Put 1st string to compare:");
    firstString = Console.ReadLine();
    Console.WriteLine("Put 2nd string to compare");
    secondString = Console.ReadLine();
}
void UserAnswer()
{
    if (CompareStrings(firstString, secondString)) Console.WriteLine("The both" +
        " strings are equals\n({0} == {1})", firstString, secondString);
    else Console.WriteLine("The both strings are not equals\n" +
            "({0} != {1})", firstString, secondString);
}
