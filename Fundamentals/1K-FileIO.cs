using System.IO;

class FileIO
{
    string folderPath = @$"/Users/prithamishra/Documents/dotnet";

    public void CreateFile()
    {
        string fullFilePath = @$"{folderPath}/abc.txt";
        File.WriteAllText(fullFilePath, "This is first text file");
    }

    public void CreateDirectory()
    {
        string newFolderPath = folderPath + "//abc";
        Directory.CreateDirectory(newFolderPath);
    }

    public void CreateDirectoriesAndFiles()
    {
        // CW - Create ten folders named Folder 1, Folder 2 and so on
        // Each of these folder should contain a file with text "I am in folder n", 
        // n being the number of folder they are in.

        for (byte counter = 0; counter <= 10; counter++)
        {
            var folderName = "Folder" + counter;
            var folderPath = @$"/Users/prithamishra/Documents/dotnet/abc/{folderName}";
            Directory.CreateDirectory(folderPath);

            var filePath = folderPath + @"/test.cs";
            File.WriteAllText(filePath, $"// I am in {folderName}");
        }        
    }

    public void GetFileMetaData()
    {
        FileInfo info = new FileInfo(@"/Users/prithamishra/Documents/dotnet/dotNet-Gautam/README.md");

        var size = info.Length / 1024 + " KB";        
    }
}