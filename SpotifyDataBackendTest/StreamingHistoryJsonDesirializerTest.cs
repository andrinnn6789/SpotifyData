using FluentAssertions;
using SpotifyDataBackend.Desirializer;
using Xunit;

namespace SpotifyDataBackendTest
{
    public class StreamingHistoryJsonDesirializerTest
    {
        [Fact]
        public void TestDesirializer()
        {
            //Arrange
            var path = "..\\..\\..\\..\\Data";

            //Act
            var tracks = StreamingHistoryJsonDesirializer.ProvideTracksFromJson(path);

            //Assert
            tracks.Should().NotBeEmpty();
        }
    }
}