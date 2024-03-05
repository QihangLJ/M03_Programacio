/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 1. Implementa la classe “Book” amb el següents atributs:
*        id: int
*        title: string
*        numpages: int
* Cal que la classe disposi dels mètodes d’accés i modificació de dades, així com  l’encadenament de constructors (major càrrega lògica i default) i sobreescrigui el mètode ToString(). Un cop implementada, genera en la controladora una col·lecció de 5 instàncies i ordena el resultat per nombre de pàgines (ascendent i descendent).
*/

using System;
using System.Collections.Generic;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book(1, "The Hobbit", 300));
            bookList.Add(new Book(2, "The Lord of the Rings", 1000));
            bookList.Add(new Book(3, "The Silmarillion", 500));
            bookList.Add(new Book(4, "The Children of Hurin", 250));
            bookList.Add(new Book(5, "The Fall of Gondolin", 200));

            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }

            bookList.Sort();
            Console.WriteLine();

            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }

            bookList.Sort(new BookComparer());
            Console.WriteLine();

            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }
        }
    }
}
