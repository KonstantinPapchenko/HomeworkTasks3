//Задание переписано с разбора на 4м занятии
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());//проверка на ввод числа

while(n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000; 
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
   

if(n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");



 
/*int number, remind, sum = 0, temp;   
Console.Write("Введите число: ");  
number = Convert.ToInt32(Console.ReadLine());  
temp = number;  
while (number > 0)  
{  
    remind = number % 10;  
    number = number / 10;  
    sum = sum * 10 + remind;  
}  Console.WriteLine("n The Reversed Number of the Original Number  is: {0} n", sum);  
if (temp == sum)  
{  
    Console.WriteLine("n Your Number is a Palindrome nn");  
}  
else  
{  
    Console.WriteLine("n Your Number is not a Palindrome nn");  
}  
Console.ReadLine();  
*/
