using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConventionPractice.Core;
using ConventionPractice.Data;
using Microsoft.EntityFrameworkCore;

namespace GeneratorData.Helpers.Constaints
{
    public static class Utils
    {
        private static Random random = new Random();
        public static void RestartApplication()
        {
            // Lấy đường dẫn đầy đủ tới ứng dụng hiện tại
            string exePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            // Bắt đầu một instance mới của ứng dụng
            System.Diagnostics.Process.Start(exePath);

            // Kết thúc instance hiện tại
            Environment.Exit(0);
        }

        //Lấy ngẫu nhiên 1 phần tử trong danh sách
        public static T GetRandomItem<T>(List<T> list)
        {
            Random random = new Random();
            int index = random.Next(0, list.Count);
            return list[index];
        }
        public static string GenerateRandomEmail(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string localPart = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return localPart + "@gmail.com";
        }
        public static DateTime GetRandomDateTime()
        {
            Random random = new Random();

            int year = random.Next(1900, 2100);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month));
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);

            DateTime randomDateTime = new DateTime(year, month, day, hour, minute, second);

            return randomDateTime;
        }
    }
}