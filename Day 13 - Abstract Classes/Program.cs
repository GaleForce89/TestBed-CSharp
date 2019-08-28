﻿using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;
    
    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    protected int price;
    
    public MyBook(String t, String a,int p) : base(t, a) //utilize base constructor and extend for MyBook
    {
        
        this.price = p;
    }
    public override void display()
    {
        Console.WriteLine("Title: {0}", this.title);
        Console.WriteLine("Author: {0}", this.author);
        Console.WriteLine("Price: {0}", this.price);

    }
}

class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}