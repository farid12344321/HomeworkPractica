

// See https://aka.ms/new-console-template for more information


#region taks1
//Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram

//Console.WriteLine("1 ededi daxil edin");
//string num1Str = Console.ReadLine();
//int num1 = Convert.ToInt32(num1Str);

//Console.WriteLine("2 ededi daxil edin");
//string num2Str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2Str);

//Console.WriteLine("3 ededi daxil edin");
//string num3Str = Console.ReadLine();
//int num3 = Convert.ToInt32(num3Str);

//int large;
//if (num1 > num2)
//{
//	if (num1 > num3)
//	{
//		large = num1;
//	}
//	else
//	{
//		large = num3;
//	}
//}else if (num2 > num3)
//{
//	large = num2;
//}
//else
//{
//	large = num3;
//}

//Console.WriteLine(large);
#endregion


#region task2
//Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

//Console.WriteLine("Yazi daxil edin");
//string text = Console.ReadLine();

//Console.WriteLine("Herif daxil edin");
//string letterStr = Console.ReadLine();
//char letter = Convert.ToChar(letterStr);

//bool check = false;

//for (int i = 0; i < text.Length; i++)
//{
//	if (text[i] == letter)
//	{
//        check = true;
//        break;
//    }
//}
//if (check) Console.WriteLine($"{letter} herfi var");
//else Console.WriteLine($"{letter} herfi yoxdur");

#endregion


#region task3
//Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
//Console.WriteLine("Yazi daxil edin");
//string text = Console.ReadLine();

//int count = 0;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'A')
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);
#endregion


#region task4
//Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
//Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

//int num;

//do
//{
//    Console.WriteLine("Eded daxil edin");
//    string numStr = Console.ReadLine();
//    num = Convert.ToInt32(numStr);
//} 
//while (num <=0 || num % 2 !=0);
//int result = num * num;
//Console.WriteLine($"Kvadrat---{result}");
#endregion


#region task5

//Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan proqram



//Console.WriteLine("Ededler daxil edin");
//string numsStr = Console.ReadLine();
//int nums = Convert.ToInt32(numsStr);

//int[] numbers = new int[nums];


//string output = "";
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. ededi yaz");
//    string numStr = Console.ReadLine();
//    int num = Convert.ToInt32(numStr);
//    numbers[i] = num;

//    if (i != 0 && num >= 0)
//        output += "+";
//    output += numStr;
//}

//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum+= numbers[i];
//}
//output += $"={sum}";
//Console.WriteLine(output);


#endregion


#region task6


//bool checkInput;
//do
//{
//    Console.WriteLine("Tehsil novunu daxil edin:");
//    string education = Console.ReadLine();
//    checkInput = true;

//    switch (education)
//    {
//        case "programming":
//            Console.WriteLine("400 saat");
//            break;
//        case "design":
//            Console.WriteLine("250 saat");
//            break;
//        case "system":
//            Console.WriteLine("200 saat");
//            break;
//        default:
//            checkInput = false;
//            Console.WriteLine("Tehsil novu yanlisdir");
//            break;
//    }
//} while (!checkInput);
#endregion
