using System;

namespace _23._01_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //int num = 2;
            //AddTen(ref num);
            //Console.WriteLine(num);


            //int point = 120;
            //ShowPoint(ref point);
            //Console.WriteLine(point);




            //int[] numbers = { 12, 5, 96, 77, 45, 6 };

            //ShowEven(ref numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //////////Metodlar/////////
            //int[] numbers = { 45, 66, 12, 3, 78, 5, 95, 14 };
            //int[] numbers2 = { 41, 88, 1 };

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers, 0, 5);

            //Console.WriteLine(numbers.GetValue(6));

            //Console.WriteLine(Array.IndexOf(numbers, 12));

            //Array.Copy(numbers, numbers2, 3 );

            //for (int i = 0; i < numbers.Length; i++)
            //    break;

            //    for (int j = 0; j < numbers2.Length; j++)
            //    {
            //        Console.WriteLine(numbers2[j]);

            //    }


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //string word = "Code Academy";

            //word = word.ToLower();
            //Console.WriteLine(word);

            //word = word.ToUpper();
            //Console.WriteLine(word);

            //word = word.Substring(0, 3);
            //Console.WriteLine(word);

            //Console.WriteLine(word.IndexOf('D'));
            //Console.WriteLine(word.LastIndexOf('d'));

            //Console.WriteLine(word.Contains("de"));

            //Console.WriteLine(word.Replace("Code", "Design"));

            //word= word.Trim();
            //Console.WriteLine(word);

            //word= word.TrimStart();
            //Console.WriteLine(word);

            // word= word.TrimEnd();
            //Console.WriteLine(word);

            //Console.WriteLine(word.StartsWith("Co"));

            //Console.WriteLine(word.EndsWith("my"));

            //string a = "Baku";
            //string b = (string)a.Clone();
            //Console.WriteLine(b);


            //string a = "Hello";
            //string b = " Baku";
            // Console.WriteLine(string.Concat(a, b));


            //string a = "Hello";
            //string b = " Baku";
            //Console.WriteLine(a.Equals(b));



            //string word = "Baku";

            //char[] cr = word.ToCharArray();
            //for (int i = 0; i < cr.Length; i++)
            //{
            //    Console.WriteLine(cr[i]);

            //}

            //string word = "Hello World";
            //Console.WriteLine("New word1:" + word.Remove(7));

            //string word = "Baku";
            //Console.WriteLine(word.Length);

            //string word = " Hello Baku";
            //Console.WriteLine(word.IsNormalized());

            //string word = " Hello Baku";
            //Console.WriteLine(word.GetTypeCode());

            //string word = " Hello Baku";
            //Console.WriteLine(word.GetType());

            //string word2 = "Hello Baku";
            //string word = "Hello Baku";
            //Console.WriteLine(word.CompareTo(word2));


            //string text = "Land of Fire";
            //var textArray = text.Split(' ');
            //for (int i = 0; i < textArray.Length; i++)
            //{
            //    Console.WriteLine(textArray[i]);
            //}



            //var newtext = string.Join(" & ", textArray);
            //Console.WriteLine(newtext);

            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsLetterOrDigit('b'));
            Console.WriteLine(char.IsUpper('x'));
            Console.WriteLine(char.IsLower('D'));


            //////////////////TASK///////////

            //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
            //Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
            //arrayim dəyişilməli və arrayin  içində əvəlki elementləri,
            //əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır



            int[] num = { 4, 6, 8 };
            AddNum(ref num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }



            static void AddNum(ref int[] arr)
            {
                arr = new int[4];
                int num = 5;

                for (int i = 0; i < arr.Length; i++)
                {
                    Array.Fill<int>(arr, num);
                    arr[1] = num;
                }

            }


        }


        //Verilmis ededi 10 vahid artiran metod

        static void AddTen(ref int num)
        {
            num +=10;
        }


        //Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 eden metod.
        //0-100 araligindadirsa oldugu kimi qalsin


        static void ShowPoint(ref int num)
        {
            if (num<0)
            {
                num =0;

            }
            else if (num>100)
            {
                num =100;
            }
        }

        //Verilmis ededler siyahisini yalniz cut deyerler qalan yeni bir arraye-e ceviren metod

        static void ShowEven(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    count++;
                }
            }

            int[] arrNew = new int[count];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    arrNew[j] = arr[i];
                    j++;
                }
            }
            arr =arrNew;
        }


    }

























}






