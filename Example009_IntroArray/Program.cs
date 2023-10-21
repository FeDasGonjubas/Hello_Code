int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6    7      8 
int[] array = { 11, 23, 52, 46, 56, 71, 344, 60, 44444 };
// array[0] = 12;


int MAX = max(max(a1, b1, c1), max(a2, b2, c2), max(a3, b3, c3));

 Console.WriteLine(MAX);
