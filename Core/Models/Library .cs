using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {
        Books[] books = new Books[] { };


        public void GetBook(Books book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length-1] = book;
        }

        public Books[] FindAllBooksByName(string value)
        {
            Books[] FindBooks = new Books[] { };    
            foreach (Books findIitem in books)
            {
                if (findIitem.Name == value || findIitem.AuthorName == value)
                {
                    Array.Resize(ref FindBooks, FindBooks.Length + 1);
                    FindBooks[FindBooks.Length - 1] = findIitem;
                }
            }
            return FindBooks;
        }

        public Books[] RemoveAllBookByName(string value)
        {
            Books[] removeBooks = new Books[] { };
            foreach (Books removeBook in books)
            {
                if (removeBook.Name != value)
                {
                    Array.Resize(ref removeBooks, removeBooks.Length + 1);
                    removeBooks[removeBooks.Length - 1] = removeBook;
                }

            }
            return books = removeBooks;
        }


        public Books[] SearchBooks(string value)
        {
            Books[] searchBooks = new Books[] { };
            foreach(Books searchIitem in books)
            {
                if (searchIitem.Name == value || searchIitem.AuthorName == value || searchIitem.PageCount.ToString() == value)
                {
                    Array.Resize(ref searchBooks, searchBooks.Length + 1);
                    searchBooks[searchBooks.Length - 1] = searchIitem;
                }
            }
            return searchBooks;
        }



    }
}
