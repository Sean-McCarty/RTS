namespace EmploymentScreening.UnitTests
{
    [TestClass]
    public class UtilitiesTests
    {
        #region AboveBelow Unit Tests

        [TestMethod]
        public void AboveBelow_ListIsNull_ReturnsCountsEqualToZero()
        {
            // Arrange
            List<int> candidates = null;
            int reference = 7;

            // Act
            Dictionary<string, int> comparisons = Utilities.AboveBelow(candidates, reference);

            //Assert
            Assert.AreEqual(0, comparisons["above"]);
            Assert.AreEqual(0, comparisons["below"]);
        }

        [TestMethod]
        public void AboveBelow_EmptyList_ReturnsCountsEqualToZero()
        {
            // Arrange
            List<int> candidates = new List<int>();
            int reference = 7;

            // Act
            Dictionary<string, int> comparisons = Utilities.AboveBelow(candidates, reference);

            //Assert
            Assert.AreEqual(0, comparisons["above"]);
            Assert.AreEqual(0, comparisons["below"]);
        }

        [TestMethod]
        public void AboveBelow_AllValuesEqualReference_ReturnsCountsEqualToZero()
        {
            // Arrange
            List<int> candidates = new List<int> { 7, 7, 7 };
            int reference = 7;

            // Act
            Dictionary<string, int> comparisons = Utilities.AboveBelow(candidates, reference);

            //Assert
            Assert.AreEqual(0, comparisons["above"]);
            Assert.AreEqual(0, comparisons["below"]);
        }

        [TestMethod]
        public void AboveBelow_ValidList_ReturnsExpectedCounts()
        {
            // Arrange
            List<int> candidates = new List<int> { 3, 2, 6, 4, 10, 8, 15, 5, 7 };
            int reference = 7;
            Dictionary<string, int> expected = new Dictionary<string, int>() { { "above", 3 }, { "below", 5 } };

            // Act
            Dictionary<string, int> comparisons = Utilities.AboveBelow(candidates, reference);

            //Assert
            Assert.AreEqual(expected["above"], comparisons["above"]);
            Assert.AreEqual(expected["below"], comparisons["below"]);
        }

        #endregion
        
        #region StringRotation Unit Tests

        [TestMethod]
        public void StringRotation_StringIsNull_ReturnsEmptyString()
        {
            // Arrange
            string original = null;
            int offset = 5;

            // Act
            var result = Utilities.StringRotation(original, offset);

            //Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void StringRotation_StringIsEmpty_ReturnsEmptyString()
        {
            // Arrange
            string original = string.Empty;
            int offset = 5;

            // Act
            var result = Utilities.StringRotation(original, offset);

            //Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void StringRotation_OffsetLessThanZero_ReturnsOriginalString()
        {
            // Arrange
            string original = @"The day is long";
            int offset = -3;

            // Act
            var result = Utilities.StringRotation(original, offset);

            //Assert
            Assert.AreEqual(original, result);
        }

        [TestMethod]
        public void StringRotation_OffsetGreaterThanLength_ReturnsOriginalString()
        {
            // Arrange
            string original = @"The day is long";
            int offset = original.Length + 2;

            // Act
            var result = Utilities.StringRotation(original, offset);

            //Assert
            Assert.AreEqual(original, result);
        }

        [TestMethod]
        public void StringRotation_ValidString_ReturnsExpectedRotatedString()
        {
            // Arrange
            string original = @"The day is long";
            int offset = 5;

            // Act
            var result = Utilities.StringRotation(original, offset);

            //Assert
            Assert.AreEqual(@" longThe day is", result);
        }

        #endregion
    }
}