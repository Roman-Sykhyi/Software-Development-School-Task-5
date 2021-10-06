using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\WebServers\home\testsite\www\myfile.txt";

            string fileName = FindFileName(filePath);
            string rootDirectory = FindRootDirectory(filePath);

            Console.WriteLine("Назва файлу без розширення: " + fileName);
            Console.WriteLine("Коренева папка: " + rootDirectory);
        }

        private static string FindFileName(string filePath)
        {
            int lastSlashPos = filePath.LastIndexOf('\\');
            int dotPos = filePath.LastIndexOf('.');

            return filePath.Substring(lastSlashPos + 1, dotPos - lastSlashPos - 1);
        }

        private static string FindRootDirectory(string filePath)
        {
            string[] parts = filePath.Split('\\');
            return parts[1];
        }
    }
}
