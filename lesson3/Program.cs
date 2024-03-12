//Tapsiriq1:Arrayin min elementini tapin.

//int[] numbers = { 25, 45, 85, 68, 78 };
//int min = int.MaxValue;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (min > numbers[i])
//    {
//        min = numbers[i];
//    }
//}
//Console.WriteLine(min);

//Tapsiriq2:String array'imiz var, console'dan (Console.ReadLine()) aldığımız index dəyərinə uyğun gələn elementi tərsinə yazdırın.
//Məsələn, {"Yusif", "Rəsul", "Ənvər"} verilib,
//console'dan 2 daxil edilibsə (daxil edilən rəqəmi int'ə çevirməyi araşdırın), ekrana "rəvnƏ" yazılsın.

//string[] s = { "Yusif", "Rəsul", "Enver" };
//int n = Convert.ToInt32(Console.ReadLine());
//string b = "";
//bool flag= true;
//for (int i = 0; i < s.Length; i++)
//{
//    if (i == n)
//    {
//        for (int j = s[i].Length-1; j >=0; j--)
//        {
//            b+= s[i][j];
//        }
//        flag = true; break;
//    }
//    else
//    {
//        flag= false;
//    }
//}
//if (flag)
//{
//    Console.WriteLine(b);
//}
//else
//{
//    Console.WriteLine("Massivde bele indeksli element yoxdur.");
//}

//Tapsiriq3: Verilmiş integer array-in  bütün elementlərini müsbətə çevirib
//yeni bir array'ə tərsinə yığın və ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.

//int[] nums = { -2, 3, 4, -5 };
//int[] nums1 = new int[nums.length];
//for (int i = nums.length-1; i >=0; i--)
//{
//    if (nums[i] < 0)
//    {
//        nums1[nums.length-1-i] = nums[i]*(-1);
//    }
//    else
//    {
//        nums1[nums.length-1-i] = nums[i];
//    }
//}
//for (int i = 0; i < nums1.length; i++)
//{
//    console.write(nums1[i]+" ");
//}

//Tapsiriq4:Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir.
//int[] nums = { -2, 3, 4, -5 };
//string s = "";
//for (int i = 0; i < nums.Length; i++)
//{
//    s += nums[i].ToString();
//    s += " ";
//}
//Console.WriteLine(s);


