Console.Clear();

void FillTable (string[,] tab) {
    for (int i = 0; i < tab.GetLength(0); i++)
        for (int j = 0; j < tab.GetLength(1); j++)
            tab[i, j] = String.Empty;
}

string[] fillValueForSpiral (string[,] tab) {
    string[] arr = new string[tab.Length];
    for (int i = 1; i < arr.Length + 1; i++) {
    arr[i - 1] = i / 10 == 0 ? "0" + i.ToString() : i.ToString();
    }
    return arr;
}

void PrintTable (string[,] table) {
	for (int i = 0; i < table.GetLength(0); i++) {
		for (int j = 0; j < table.GetLength(1); j++)
			Console.Write($"{table[i, j]}  ");
		Console.WriteLine();
		}
}

string [,] spiralArray = new string[9, 6]; //размер массива
FillTable(spiralArray);
string[] valueForSpiral = fillValueForSpiral(spiralArray);

string direction = "right"; //bottom, left, top
int i = 0, j = 0;
for (int k = 0; k < valueForSpiral.Length;) {
    spiralArray[i, j] = valueForSpiral[k];
    if (k == valueForSpiral.Length - 1) break;
    switch (direction) {
        case "right":
            if (j + 1 > spiralArray.GetUpperBound(1) || spiralArray[i, j + 1] != String.Empty) direction = "bottom";
            else {j++; k++;}
            break;
        case "bottom":
            if (i + 1 > spiralArray.GetUpperBound(0) || spiralArray[i + 1, j] != String.Empty) direction = "left";
            else {i++; k++;}
            break;
        case "left":
            if (j - 1 < 0 || spiralArray[i, j - 1] != String.Empty) direction = "top";
            else {j--; k++;}
            break;
        case "top":
            if (i - 1 < 0 || spiralArray[i - 1, j] != String.Empty) direction = "right";
            else {i--; k++;}
            break;
    }
}

PrintTable(spiralArray);