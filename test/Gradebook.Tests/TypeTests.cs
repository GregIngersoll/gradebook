using System;
using Xunit;

namespace Gradebook.Tests
{
   public class TypeTests
   {
      [Fact]
      public void StringsBehaveLikeValueType()
      {
         string name = "Foo";
         string upperName = MakeUppercase (name);

         Assert.Equal ("FOO", upperName);
      }

      private string MakeUppercase(string name)
      {
         return name.ToUpper();
      }

      [Fact]
      public void ValueTypesAlsoPassByValue()
      {
         var x = GetInt();
         SetInt (ref x);

         Assert.Equal (42, x);
      }

      private void SetInt(ref int x)
      {
         x = 42;
      }

      private int GetInt()
      {
         return 3;
      }

      [Fact]
      public void CSharpCanPassByReference()
      {
         // Arrange
         var book1 = GetBook("Book1");
         GetBookSetNameRef (out book1, "New Name");
         
         // Act
         
         
         // Assert
         Assert.Equal ("New Name", book1.Name);
      }

      private void GetBookSetNameRef(out Book book, string name)
      {
         book = new Book (name);
      }

      [Fact]
      public void CSharpIsPassByValue()
      {
         // Arrange
         var book1 = GetBook("Book1");
         GetBookSetName (book1, "New Name");
         
         // Act
         
         
         // Assert
         Assert.Equal ("Book1", book1.Name);
      }

      private void GetBookSetName(Book book, string name)
      {
         book = new Book ("name");
      }

      [Fact]
      public void CanSetNameFromReference()
      {
         // Arrange
         var book1 = GetBook("Book1");
         SetName (book1, "New Name");
         
         // Act
         
         
         // Assert
         Assert.Equal ("New Name", book1.Name);
      }

      private void SetName(Book book, string name)
      {
         book.Name = name;
      }

      [Fact]
      public void GetBookReturnsDifferentObjects()
      {
         // Arrange
         var book1 = GetBook("Book1");
         var book2 = GetBook("Book2");
         
         // Act
         
         
         // Assert
         Assert.Equal ("Book1", book1.Name);
         Assert.Equal ("Book2", book2.Name);
      }

      [Fact]
      public void TwoVariablesReferenceSameObjects()
      {
         // Arrange
         var book1 = GetBook("Book1");
         var book2 = book1;
         
         // Act
         
         // Assert
         Assert.Same (book1, book2);
         Assert.True (Object.ReferenceEquals(book1, book2));
      }

      private Book GetBook(string name)
      {
         return new Book (name);
      }
   }
}
