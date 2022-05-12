using Training_Center_Task_2;

Console.WriteLine("Enter matrix size: ");
int matrixSize = int.Parse(Console.ReadLine());

var matrix = new SquareMatrix<T>();

Console.WriteLine("Enter values to fill in matrix in format 'row col value,row col value,...'. To stop entering values, write 'STOP!'");
string[] values = Console.ReadLine().Split(',').ToArray();
