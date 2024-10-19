using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
namespace hw1
{
    public class CreditCard
    {
        // Задание 3 Создайте класс «Кредитная карточка». Вам необходимо
// хранить информацию о номере карты, ФИО владельца, CVC, 
// дата завершения работы карты и т.д. Предусмотреть механизмы 
// для инициализации полей класса. Если значение
// для инициализации неверное, генерируйте исключение.

public string Name { get; set; }
public string Surname { get; set; }
public string Patronymic {get; set;}
public string Number { get; set;}
public int Cvc { get; set; }
public string Issue { get; set; }
public int Errors { get; set;}

public CreditCard(){
      Name = "";
      Surname = "";
      Patronymic = ""; 
      Number = "";
      Cvc = 0; 
      Issue = "";
      Errors = 0;

      Write("карта создана. card created \n\n");
}

public void newCard(){


WriteLine("введите имя: ");
Name = ReadLine();
  
WriteLine("введите фамилию: ");
Surname = ReadLine();

WriteLine("введите отчество: ");

            Patronymic = ReadLine();

            try
            {

WriteLine("введите номер карты: ");
Number = ReadLine();

   if (string.IsNullOrEmpty(Number) || !Number.All(char.IsDigit))
            {
                throw new ArgumentException("номер карты должен содержать только цифры. card number must contains only digits");
            }

if(Number.Length != 16){
    throw new Exception("неверный номер карты. incorrect card number");
}

}
catch(ArgumentException ex){
      Number = "";
      WriteLine("произошла ошибка: " + ex.Message);
      Errors++;
      return;
}

catch(Exception ex){
      WriteLine("произошла ошибка: " + ex.Message);
      Errors++;
      return;
}


  try{

WriteLine("введите CVC-код: ");
string cvc = ReadLine();
int cvcRes = int.Parse(cvc);
Cvc = cvcRes;
if(cvcRes < 100 || cvcRes > 999){
    throw new Exception("неверный формат cvc. incorrect cvc format");
}
  }
  catch(Exception ex){
    Cvc = 0;
    WriteLine("произошла ошибка: " + ex.Message);
    Errors++;
    return;
  }

Issue = "10.10.2030";

}

public void Print(){
    Write("номер карты: " + Number + "\n");
    Write("имя: " + Name + "\n");
    Write("отчество: " + Patronymic + "\n");
    Write("фамилия: " + Surname + "\n");
    Write("cvc код: " + Cvc + "\n");
    Write("срок действия до: " + Issue + "\n");
}





    }


   
}




#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.