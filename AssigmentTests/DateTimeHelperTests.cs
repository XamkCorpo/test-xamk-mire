using OOP_Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTests
{
    public class DateTimeHelperTests
    {
        [Fact]
        public void IsLeapYear_ReturnsTrueForLeapYear()
        {
            // Arrange
            DateTime year = new DateTime(2020, 1, 1);

            // Act
            var result = DateTimeHelper.IsLeapYear(year);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLeapYear_ReturnsFalseForLeapYear()
        {
            // Arrange
            DateTime year = new DateTime(2021, 1, 1);

            // Act
            var result = DateTimeHelper.IsLeapYear(year);

            // Assert
            Assert.False(result);
        }

        //[Theory]
        //[InlineData("2022-03-15", "2022-03-15")]
        //[InlineData("2022-07-31", "2022-07-31")]
        //[InlineData("2021-12-25", "2021-12-25")]
        //public void ConvertToDateTime_ReturnsFirstDayOfMonth(string inputDate, string expectedDate)
        //{
        //    // Arrange
        //    var expectedDateTime = DateTime.Parse(expectedDate);

        //    // Act
        //    var actualDateTime = DateTimeHelper.ConvertToDateTime(inputDate);

        //    // Assert
        //    Assert.Equal(expectedDateTime, actualDateTime);
        //}

        [Theory]
        [InlineData("2000-01-01", 24)] // Assuming current year is 2024
        [InlineData("1980-12-31", 43)] // Assuming current year is 2024
        public void CalculateAge_ReturnsCorrectAge(DateTime birthDate, int expectedAge)
        {
            var age = DateTimeHelper.CalculateAge(birthDate);
            Assert.Equal(expectedAge, age);
        }

        [Fact]
        public void GetCurrentDateTime_ReturnsCurrentDateTime()
        {
            string expected = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string result = DateTimeHelper.GetCurrentDateTime();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDaysUntilNextBirthday_BirthdayNextMonth()
        {
            var birthDate = new DateTime(1990, 2, 15);
            var currentDate = new DateTime(2023, 1, 10);
            var expectedDays = 36; // Calculate this based on your implementation

            var actualDays = DateTimeHelper.DaysUntilNextBirthday(birthDate, currentDate);

            Assert.Equal(expectedDays, actualDays);
        }
    }
}
