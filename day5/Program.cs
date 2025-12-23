using System;
using System.Collections.Generic;
using LibraryItems = LibrarySystem.Items;

class Program
{
    public static void Main()
    {
        Console.WriteLine("=== TASK 1: Abstract Class & Abstract Methods ===");
        var book = new LibraryItems.Book { Title = "C# Fundamentals", Author = "John Doe", ItemID = 101 };
        var magazine = new LibraryItems.Magazine { Title = "Tech Today", Author = "Jane Doe", ItemID = 201 };
        
        book.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {book.CalculateLateFee(3)}");
        Console.WriteLine();
        
        magazine.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {magazine.CalculateLateFee(3)}");
        Console.WriteLine();

        Console.WriteLine("=== TASK 2: Interfaces & Multiple Inheritance ===");
        ((IReservable)book).ReserveItem();
        ((INotifiable)book).SendNotification("Your reserved book is ready for pickup.");
        Console.WriteLine();

        Console.WriteLine("=== TASK 3: Dynamic Polymorphism ===");
        List<LibrarySystem.Items.LibraryItem> items = new List<LibrarySystem.Items.LibraryItem> { book, magazine };
        foreach (var item in items)
        {
            item.DisplayItemDetails();
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("=== TASK 4: Explicit Interface Implementation ===");
        IReservable reservableBook = book;
        INotifiable notifiableBook = book;
        reservableBook.ReserveItem();
        notifiableBook.SendNotification("Please return the book on time.");
        Console.WriteLine();

        Console.WriteLine("=== TASK 5: Namespaces & Nested Namespaces ===");
        var aliasBook = new LibraryItems.Book();
        var aliasMagazine = new LibraryItems.Magazine();
        Console.WriteLine("Book and Magazine objects created using namespace alias.");
        Console.WriteLine();

        Console.WriteLine("=== TASK 6: Partial & Static Classes ===");
        LibraryAnalytics.TotalBorrowedItems = 5;
        LibraryAnalytics.DisplayAnalytics();
        Console.WriteLine();

        Console.WriteLine("=== TASK 7: Enumerations ===");
        var member = new LibrarySystem.Users.Member { Name = "Alice", Role = UserRole.Member };
        var itemStatus = ItemStatus.Borrowed;
        Console.WriteLine($"User Role: {member.Role}");
        Console.WriteLine($"Item Status: {itemStatus}");
        Console.WriteLine();

        Console.WriteLine("=== BONUS TASK ===");
        member.SendRoleBasedNotification();
        var admin = new LibrarySystem.Users.Member { Role = UserRole.Admin };
        admin.SendRoleBasedNotification();
        
        var ebook = new LibraryItems.eBook { Title = "Digital C#", Author = "Tech Author", ItemID = 301 };
        ebook.DownloadBook();
    }
}