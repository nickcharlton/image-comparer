using System;
using System.IO;
using ImageComparer;
using Xunit;

namespace ImageComparerTests
{
    public class DuplicateImageFinderTest
    {
        [Fact]
        public void FindSimilarImages_SearchesADirectoryForSimilarImages()
        {
            var fixturesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Fixtures");
            var whiteImagePath = Path.Combine(fixturesDirectory, "White.png");

            var similarToWhite = DuplicateImageFinder.FindSimilarImages(whiteImagePath, fixturesDirectory, true, 0, 20);
            var halfOfImageDifferent = DuplicateImageFinder.FindSimilarImages(whiteImagePath, fixturesDirectory, true, .50f, 0);

            Assert.Single(similarToWhite);
            Assert.Single(halfOfImageDifferent);
        }
    }
}
