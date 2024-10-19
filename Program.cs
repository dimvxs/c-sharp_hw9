// See https://aka.ms/new-console-template for more information
using hw1;
using System;
using System.Linq.Expressions;
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.


// CreditCard card = new CreditCard();
// card.newCard();
// if(card.Errors == 0){
// card.Print();
// }


// Задание 4 Пользователь вводит в строку с клавиатуры
//  математическое выражение. Например, 3*2*1*4. Программа 
//  должна посчитать результат введенного выражения.
// В строке могут быть только целые числа и оператор *. Для обработки
// ошибок ввода используйте механизм исключений.


void count(){

            const int maxNumbers = 10;
            const int maxOperators = 9;
            int[] numbers = new int[maxNumbers];
            char[] operators = new char[maxOperators];
            int numberCount = 0, operatorCount = 0;




    Console.WriteLine("enter an expression: ");
    string expression = Console.ReadLine();
    try{
  for (int i = 0; i < expression.Length; i++)
            {
                // Если символ - цифра, извлекаем число
                if (char.IsDigit(expression[i]))
                {
                    string numberStr = "";
                    while (i < expression.Length && char.IsDigit(expression[i]))
                    {
                        numberStr += expression[i];
                        i++;
                    }
                    numbers[numberCount++] = int.Parse(numberStr); // Добавляем число в массив
                    i--; // Корректируем индекс
                }
                // Если символ - оператор, добавляем его в массив
                else if ("+-*/".Contains(expression[i]))
                {
                    operators[operatorCount++] = expression[i];
                }
                else
                {
                    throw new FormatException($"Некорректный символ: {expression[i]}");
                }
                
            }
    

     int result = numbers[0];
            for (int j = 0; j < operatorCount; j++)
            {
                int nextNumber = numbers[j + 1];
                switch (operators[j])
                {
                    case '+':
                        result += nextNumber;
                        break;
                    case '-':
                        result -= nextNumber;
                        break;
                    case '*':
                        result *= nextNumber;
                        break;
                    case '/':
                        result /= nextNumber;
                        break;
                }
            }

            Console.WriteLine($"Результат: {result}");
            
        } 
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка ввода: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }



}

   
count();


#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
