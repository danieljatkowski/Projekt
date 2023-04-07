var number = "4566";

char[] letters = number.ToArray();

char[] cx = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int[] result = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int i = 0;

foreach (char cxi in cx)
{
    foreach (char chl in letters)
    {
        if (cxi == chl) { result[i]++; }
    }
    Console.WriteLine(i + " ==> " + result[i]);
    i++;
}


