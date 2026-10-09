using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace mietorn.Excercise_07
{
    internal class btvn11
    {
        public static void Main50(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Hãy nhập chuỗi của bạn: "); //Bài 1: to input a string and print it.
            string chuoinhap = Console.ReadLine();
            Console.WriteLine($"Chuỗi bạn vừa nhập là: {chuoinhap}");

            int dodai = 0; //Bải 2: to find the length of a string without using a library function.
            if (chuoinhap == null)
                Console.WriteLine("Chuỗi không tồn tại!");
            else
            {
                foreach (char c in chuoinhap) dodai++;
                Console.WriteLine($"Độ dài chuỗi là: {dodai}");
            }

            string ketqua1 = "";
            foreach (char c in chuoinhap) ////Bài 3: to separate individual characters from a string.
            {
                ketqua1 += c + " ";
            }
            Console.WriteLine($"Chuỗi sau khi tách các ký tự là: {ketqua1}");

            for (int i = dodai - 1; i >= 0; i--) //Bài 4: to print individual characters of the string in reverse order.
                Console.Write($"{chuoinhap[i]} ");
            Console.WriteLine();

            int dem = 0; //Bài 5: to count the total number of words in a string.
            bool inWord = false;
            foreach (char c in chuoinhap)
            {
                if (char.IsWhiteSpace(c)) inWord = false;
                else if (!inWord)
                {
                    inWord = true;
                    dem++;
                }
            }
            Console.WriteLine($"Tổng số từ trong chuỗi là: {dem}");

            Console.Write("Nhập chuỗi tiếp theo: "); //Bài 6: to compare two strings without using a string library functions.
            string chuoinhap2 = Console.ReadLine();
            bool isEqual = true;
            int dodai2 = 0;
            if (chuoinhap2 == null)
                Console.WriteLine("Chuỗi thứ hai không tồn tại!");
            else
            {
                foreach (char c in chuoinhap2) dodai2++;
                if (dodai != dodai2) isEqual = false;
                else
                {
                    for (int i = 0; i < dodai; i++)
                    {
                        if (chuoinhap[i] != chuoinhap2[i])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }
                Console.WriteLine($"2 chuỗi {(isEqual ? "bằng nhau" : "không bằng nhau")}");
            }

            int alphabets = 0, digits = 0, specialChars = 0, vowels = 0, consonants = 0; //Bài 7: to count the number of alphabets, digits and special characters in a string.
            string nguyenam = "aeuioAEUIO";
            foreach (char c in chuoinhap)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specialChars++;
            }
            Console.WriteLine($"Số lượng chữ cái chuỗi đầu tiên là: {alphabets}");
            Console.WriteLine($"Số lượng chữ số chuỗi đầu tiên là: {digits}");
            Console.WriteLine($"Số lượng ký tự đặc biệt chuỗi đầu tiên là: {specialChars}");

            foreach (char c in chuoinhap) //Bài 8: to count the number of vowels or consonants in a string.
            {
                if (nguyenam.Contains(c))
                {
                    vowels++;

                }
                else
                {
                    consonants++;
                }

            }
            Console.WriteLine($"Số lượng nguyên âm chuỗi đầu tiên là: {vowels}");
            Console.WriteLine($"Số lượng phụ âm chuỗi đầu tiên là: {consonants}");

            Console.Write("Nhập chuỗi phụ: "); //Bài 9: to check whether a given substring is present in the given string.
            string sub = Console.ReadLine();
            int dodaisub = 0;
            foreach (char c in sub) dodaisub++;
            for (int i = 0; i <= dodai - dodaisub; i++)
            {
                bool match = true;
                for (int j = 0; j < dodaisub; j++)
                {
                    if (chuoinhap[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
            }
            if (chuoinhap.IndexOf(sub) == -1)
            {
                Console.WriteLine("Chuỗi phụ không tồn tại trong chuỗi chính.");
            }
            else
            {
                Console.WriteLine($"Chuỗi phụ '{sub}' có tồn tại trong chuỗi chính.");
            }

            int pos = -1; //Bài 10: to find the position of a substring in a string.
            for (int i = 0; i <= dodai - dodaisub; i++)
            {
                bool match = true;
                for (int j = 0; j < dodaisub; j++)
                {
                    if (chuoinhap[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
            {
                Console.WriteLine($"Vị trí của chuỗi phụ '{sub}' trong chuỗi chính là: {pos}");
            }
            else
            {
                Console.WriteLine("Chuỗi phụ không tồn tại trong chuỗi chính.");
            }

            Console.Write("Nhập kí tự để kiểm tra: "); //Bài 11: to check whether a character is an alphabet and not and if so, check for the case.
            char checkChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(checkChar))
            {
                Console.WriteLine($"{checkChar} là một chữ cái.");
                if (char.IsUpper(checkChar))
                {
                    Console.WriteLine($"{checkChar} là chữ hoa.");
                }
                else
                {
                    Console.WriteLine($"{checkChar} là chữ thường.");
                }
            }
            else
            {
                Console.WriteLine($"{checkChar} không phải là chữ cái.");
            }

            int count = 0; //Bài 12: to find the number of times a substring appears in a given string.
            for (int i = 0; i <= dodai - dodaisub; i++)
            {
                bool match = true;
                for (int j = 0; j < dodaisub; j++)
                {
                    if (chuoinhap[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                }
            }
            Console.WriteLine($"Số lần xuất hiện của chuỗi phụ '{sub}' trong chuỗi chính là: {count}");

            string insertString = Console.ReadLine(); //Bai2 13: to insert a substring before the first occurrence of a string.
            if (pos != -1)
            {
                string result = chuoinhap.Substring(0, pos) + insertString + chuoinhap.Substring(pos);
                Console.WriteLine($"Chuỗi sau khi chèn: {result}");
            }
            else
            {
                Console.WriteLine("Chuỗi phụ không tồn tại trong chuỗi chính. Không thể chèn.");
            }
        }
    }
}



