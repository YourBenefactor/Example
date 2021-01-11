using System;
using System.IO;
using System.Windows.Forms;

namespace Пример
{
    public partial class Example : Form
    {
        private Random randomizer = null;
        private string filePath = null; // Путь к файлу
        private string directory = null; // Путь к папке

        public Example()
        {
            InitializeComponent();
            randomizer = new Random();
        }

        private void WriteTextFile_Click(object sender, EventArgs e) // Button Method
        {
            string fileName = FileName.Text;
            SaveFileToDirectory(fileName);

            string filePath = GetPathToFile(fileName);
            WriteRandomFile(filePath);
            ReadFile(filePath, RecordedFile);
        }

        private void ReadTextFile_Click(object sender, EventArgs e) // Button Method
        {
            ReadFile(filePath, OpenFile);
        }



        // Выбор папки
        private void FolderSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog()) // Создает диалоговое окно с выбором папки
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK) // Выполняется, если пользователь подтверждает выбор папки
                {
                    directory = openFileDialog.SelectedPath; // Хранит в себе путь к папке, которую выбрал пользователь
                    PathToFolder.Text = directory; // Выводит путь на форму (TextBox)
                }
            }
        }

        // Выбор файла
        private void FileSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // Вызывает диалоговое окно с выбором файла
            {
                openFileDialog.InitialDirectory = "c:\\"; // Директория, с которой начинается выбор файла
                openFileDialog.Filter = "txt files (*.txt)|*.txt"; // Формат фала (Название, которое будет отображаться | *.расширение файла)
                openFileDialog.FilterIndex = 2; // Не знаю, что делает, наверно что-то важное
                openFileDialog.RestoreDirectory = true; // Тоже хз

                if (openFileDialog.ShowDialog() == DialogResult.OK) // Выполняется, если пользователь подтверждает выбор файла
                {
                    filePath = openFileDialog.FileName; // Хранит в себе путь к файлу, который выбрал пользователь
                    PathToFile.Text = filePath; // Передает путь в TextBox
                }
            }
        }

        // Создание файла
        private void SaveFileToDirectory(string fileName)
        {
            if (String.IsNullOrEmpty(fileName)) return; // Задано ли название файла?
            if (String.IsNullOrEmpty(directory)) return; // Была ли задан путь к папке?
            if (!Directory.Exists(directory)) return; // Существует ли папка?

            FileStream file = File.Create(GetPathToFile(fileName)); // Создание файла
            file.Close(); // Закрытие файла
        }

        // Запись в файл
        private void WriteRandomFile (string filePath)
        {
            if (String.IsNullOrEmpty(filePath)) return; // Отсутствует ли путь к файлу?
            if (!File.Exists(filePath)) File.Create(filePath); // Если файл не существует, то создает по заданному пути

            using (StreamWriter writter = new StreamWriter(filePath)) // Безопасная запись в файл
            {
                for (int i = 0; i < 10; i++) // Кол-во строк
                { 
                    for (int j = 0; j < 10; j ++) // Кол-во символов в строке
                    {
                        int randomValue = randomizer.Next(-100,100);
                        writter.Write($"{randomValue} "); // Записать информацию в файл
                    }
                    writter.Write("\r\n"); // Перенос на следующую строку
                }
                writter.Close(); // Закрытие файла
            }
        }

        // Чтение файла
        private void ReadFile(string filePath, TextBox Output)
        {
            if (String.IsNullOrEmpty(filePath)) return; // Отсутствует ли путь к файлу?
            if (!File.Exists(filePath)) return; // Проверка на существование файла

            string text = "";
            using (StreamReader reader = new StreamReader(filePath)) // Безопасное считывание файла
            {
                text = reader.ReadToEnd(); // Считывает файл полностью

                //Если считан весь файл, то можно перейти к его началу:
                reader.DiscardBufferedData(); // Сброс информации о чтении файла
                reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin); // Переход к 1 символу файла

                // Можно также считать файл построчно
                //while (!reader.EndOfStream) // Пока не закончился файл
                //{
                //    text += reader.ReadLine(); // Считывает одну строку
                // }

                Output.Text = text;
                reader.Close(); // Закрытие файла
            }
        }

        // Получение пути к файлу
        private string GetPathToFile(string fileName)
        {
            return Path.Combine(directory, $"{fileName}.txt"); // directory = "С://", fileName = "file" => Вернет "С://file.txt/"
        }
    }
}
