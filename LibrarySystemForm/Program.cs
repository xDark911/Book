using LibrarySystem.BL.File;
using LibrarySystem.BL.Interface;
using LibrarySystem.Models;
using System.Collections.Generic;

namespace LibrarySystemForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            IBookManager bookmanager = new BookFile();
            //bookmanager.ReadBooks(List < Book > BookList, string path, ref comboBox1);
            //bookmanager.RentBook(List<Book> BookList, List<Info> InfoList, int value);
            //bookmanager.WriteBook(List<Book> BookList, string path);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}