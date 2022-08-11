using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        private int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += new WriteLogDelegate(ReturnMessage);
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal("hello!", result);
            Assert.Equal(3, count);
        }
        [Fact]
        public void LogDelegateIsDumb()
        {
            string log;

            log = ReturnMessage("Hello!");

            Assert.Equal("Hello!", log);
        }
        private string IncrementCount(string message)
         {
            count++;
            return message.ToLower();
         }

         private string ReturnMessage(string message)
         {
            count++;
            return message;
         }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "scott";
            string upper = MakeUppercase(name);

            Assert.Equal("scott", name);
            //Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string name)
        {
            name.ToUpper();
            return name;
        }

        [Fact]
        public void Test1()
        {
            //without ref this test 
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(x,42);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
                      
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("book 1", book1.Name);
                      
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
                      
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        [Fact]
        public void TestName()
        {
            // Given
        
            // When
        
            // Then
        }
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("book 1");
            var book2 = GetBook("book 2");

            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 2", book2.Name);
            // arrange

            // act

            // assert                        
        }

         public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("book 1");
            var book2 = book1;

            Assert.Same(book1,book2);
            // arrange

            // act

            // assert                        
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }

}