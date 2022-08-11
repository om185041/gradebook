
namespace GradeBook.Tests
{
    public class BookTests 
    {
        [Fact]
        public void BookCalculatesTheStatistics()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
           var result = book.ShowStats();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            Assert.Equal('B',result.Letter);
                        
        }

        [Fact]
        public void BookCalculatesNumOfBooks()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
           var result = book.NumberOfBooks();

            // assert
            Assert.Equal(result, 3);
        }

          [Fact]
        public void BookUseLetterForGrades()
        {
            // arrange
            var book = new Book("");
           book.AddLetterGrade('a');
           book.AddLetterGrade('b');
           book.AddLetterGrade('c');

            // act
           var result = book.ShowStats();
           double[] x = { 90, 80, 70};
           

            // assert
           
            Assert.Equal(x.Average(), result.Average);
        }
        
           [Fact]
        public void MathTest()
        {
            // arrange
           double[] x = { 90, 80, 75};
           double y;

           double[] a = { 90, 80, 70};
           double b;

            // act
           
           y= (90+80+75)/3;
           b= (90+80+70)/3;
           

            // assert
           
            Assert.Equal(x.Average(), y); //this fails
            Assert.Equal(a.Average(), b); //this passes
        }
        
    }

}