Console.Clear(); //Очищает консоль каждый раз когда запускается программа.
//Console.SetCursorPosition(10, 4); //Выставляет выбранный символ в указанную позицию (10-отступ сбоку,
//4-отступ строками). Ниже WriteLine "+" этот знак будет выставлен в терминале.
//Console.WriteLine("+");

int xa = 40; 
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;   
// или можно указать через запятую в столбик:
//int xa = 1, ya = 1,
//    xb = 1, yb = 30,
//    xc = 60, yc = 30;   

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;
while(count < 10000)// While - оператор цикла. Когда используется while обязательно надо ставить счетчик count, чтобы программа
//не ушла в бесконечный цикл.
{
    int what = new Random().Next(0, 3); //(1, 3) - это 0 1 2.
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

      if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

      if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}