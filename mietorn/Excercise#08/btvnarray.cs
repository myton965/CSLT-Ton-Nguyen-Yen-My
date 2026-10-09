using System;
using System.Collections.Generic;
using System.Text;

namespace mietorn.Excercise_08
{
    internal class btvnarray
    {
        static void Main(string[] args)
        {
            string file1 = "test1.txt";
            string file2 = "test2.txt";
            string file3 = "test3.txt";
            string dirPath = "./TestFolder";

            // 1. Create a blank file on the disk.
            File.Create(file1).Close();
            Console.WriteLine("1. Blank file created.");
            Console.ReadLine();

            // 2. Remove a file from the disk.
            File.Delete(file1);
            Console.WriteLine("2. File removed.");

            // 3. Create a file and add some text.
            File.WriteAllText(file1, "Hello, this is a C# file handling test.\n");
            Console.WriteLine("3. File created with some text.");

            // 4. Create a text file and read it.
            string content = File.ReadAllText(file1);
            Console.WriteLine($"4. Read from file: {content.Trim()}");

            // 5. Create a file and write an array of strings.
            string[] arr = { "Line 1", "Line 2", "Line 3", "Line 4" };
            File.WriteAllLines(file2, arr);
            Console.WriteLine("5. Array of strings written to file2.");

            // 6. Append some text to an existing file.
            File.AppendAllText(file2, "Line 5 (Appended)\n");
            Console.WriteLine("6. Text appended.");

            // 7. Create, copy to another name, and display content.
            File.Copy(file2, file3, true);
            Console.WriteLine($"7. Copied to {file3}. Content of {file3}:");
            Console.WriteLine(File.ReadAllText(file3));

            // 8. Create, move into the same directory with another name (Rename).
            string movedFile = "test_moved.txt";
            if (File.Exists(movedFile)) File.Delete(movedFile);
            File.Move(file3, movedFile);
            Console.WriteLine($"8. File moved/renamed to {movedFile}");

            // 9. Read the first line of a file.
            string[] lines = File.ReadAllLines(file2);
            Console.WriteLine($"9. First line: {lines[0]}");

            // 10. Read the last line of a file.
            Console.WriteLine($"10. Last line: {lines[lines.Length - 1]}");

            // 11. Read the last n lines of a file.
            int n = 2;
            Console.WriteLine($"11. Last {n} lines:");
            for (int i = lines.Length - n; i < lines.Length; i++) Console.WriteLine(lines[i]);

            // 12. Read a specific line from a file (e.g., line 2, index 1).
            Console.WriteLine($"12. Specific line (Line 2): {lines[1]}");

            // 13. Count the number of lines in a file.
            Console.WriteLine($"13. Total number of lines: {lines.Length}");

            // 14. Print the structure of a specific folder (including files).
            Directory.CreateDirectory(dirPath);
            File.WriteAllText(Path.Combine(dirPath, "subfile.txt"), "test");
            Console.WriteLine($"14. Structure of directory '{dirPath}':");
            foreach (string file in Directory.GetFiles(dirPath))
            {
                Console.WriteLine($"   - File: {Path.GetFileName(file)}");
            }

            // 15. Statistics using 2D (Rectangular) and Jagged Arrays.
            Console.WriteLine("\n15. Character Statistics (Rectangular & Jagged Arrays)");
            AnalyzeFileStatistics(file2);
        }

        static void AnalyzeFileStatistics(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            // Dùng mảng 2 chiều chữ nhật: [Mã ASCII, 0: Cột thống kê số lượng]
            int[,] charStats = new int[256, 1];

            // Dùng Jagged Array: mảng của các mảng chứa vị trí [Dòng, Cột]
            // Mỗi index tương ứng với mã ASCII của ký tự sẽ chứa 1 mảng các chuỗi/struct mô tả tọa độ
            string[][] positions = new string[256][];

            // Khởi tạo jagged array rỗng
            for (int i = 0; i < 256; i++)
            {
                positions[i] = new string[0];
            }

            for (int lineIdx = 0; lineIdx < lines.Length; lineIdx++)
            {
                for (int colIdx = 0; colIdx < lines[lineIdx].Length; colIdx++)
                {
                    char c = lines[lineIdx][colIdx];
                    if (c < 256 && char.IsLetterOrDigit(c)) // Chỉ xét chữ và số
                    {
                        // 1. Tăng số đếm trong mảng 2 chiều (chữ nhật)
                        charStats[c, 0]++;

                        // 2. Thêm vị trí vào Jagged array
                        string posStr = $"(L:{lineIdx + 1}, C:{colIdx + 1})";

                        // Mở rộng mảng con để thêm phần tử mới
                        int currentLen = positions[c].Length;
                        Array.Resize(ref positions[c], currentLen + 1);
                        positions[c][currentLen] = posStr;
                    }
                }
            }

            // In kết quả
            for (int i = 0; i < 256; i++)
            {
                if (charStats[i, 0] > 0)
                {
                    char c = (char)i;
                    Console.Write($"Char '{c}' appears {charStats[i, 0]} times at: ");

                    // In các vị trí từ Jagged Array
                    for (int j = 0; j < positions[i].Length; j++)
                    {
                        Console.Write($"{positions[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }//Open file explorer -> bin -> net -> file 
        }
    }
}
