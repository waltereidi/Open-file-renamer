
namespace Tests
{
    public class Configuration
    {
        public readonly DirectoryInfo _testDirPath;

        public Configuration()
        {
            _testDirPath = new
                (
                    Path.Combine(
                        Directory.GetParent(AppContext.BaseDirectory)
                            .Parent.Parent.Parent.Parent.FullName, "Tests")
                );
        }

    }
}