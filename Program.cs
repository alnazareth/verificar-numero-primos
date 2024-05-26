int num;
Console.WriteLine("Escribe numero");
num = int.Parse(Console.ReadLine());

Console.WriteLine(IsPrime(num));

 static bool IsPrime(int num){

for (int i = 2; i < num; i++)
{
    if (num% i ==0) return false;
    
}

return true;
}



Console.WriteLine("El numero ingresado es:"+ num);