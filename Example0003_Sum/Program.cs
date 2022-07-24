//Один вариант решения:
//int numberA = 3; //Создали переменную и положили в нее значение 3. Добавили уточнение, что число целое (int).
//int numberB = 5;
//Console.WriteLine(numberA + numberB); //Делаем вывод в консоль сумму чисел.

//Второй вариант решения через промежуточную переменную:
//int numberA = 31; //Создали переменную и положили в нее значение 3. Добавили уточнение, что число целое (int).
//int numberB = 5;
//int result = numberA + numberB; //Промежуточная переменная.
//Console.WriteLine(result); //Делаем вывод в консоль сумму чисел.

//Вариант решения со случайными числами:
int numberA = new Random().Next(1, 10); // new random().Next(1, 10) - позволяет генерировать случайные
//числа в диапазоне от 1 до 10 (диапазон можно менять). 
Console.WriteLine(numberA); //Прописывается, чтобы выводило в терминал выбранное случайно число.
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);