
// проверка на значность

// int number = 100;

// if (number >= 100 && number <= 999) 
// {
//     Console.WriteLine(" Число трехзначное")
// }
// else
// {
//     Console.WriteLine(" Число не трехзначное")
// }

// string testNumber = Console.ReadLine();

// Console.WriteLine(testNumber[0]); // " 9 "

// Console.WriteLine(testNumber[1]); // " 0 "

// Console.WriteLine(testNumber[2]); // " 9 "  

// var имя переменной = значение

var stringNumber = "привет";

int Number; // если строчка состоит из чисел, то сюда попадает наше число

bool isNumber = int.TryParse(stringNumber, out Number); // true - строчка состоит из чисел, false - присутствуют спец символы, это преобразование строчки в формат числа.(если в строчке только цифры,
// то проверка произсходит успешно

//if ()


Console.WriteLine(isNumber);
Console.WriteLine(Number);
