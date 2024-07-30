using System;
using System.Collections.Generic;

var book1 = new Book("The Pragmatic Programmer", 352, "English");
var book2 = new Book("Clean Code", 464, "English");
var book3 = new Book("Clean Code", 464, "English");
var book4 = book3 with { Language = "Italian" };

var likes = new Dictionary<Book, int> { [book1] = 10 };

var (name, pages, language) = book1;

Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(book3);
Console.WriteLine("book 2 == book3: " + (book2 == book3));
Console.WriteLine("book 3 == book4: " + (book3 == book4));
Console.WriteLine("likes[book1]: " + likes[book1]);
Console.WriteLine($"Book1: {name} {pages} {language}");

public record Book(string Name, int Pages, string Language);