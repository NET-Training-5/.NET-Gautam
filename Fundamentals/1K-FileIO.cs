class FileIO
{
    public void CreateFile()
    {
        string folderPath = @"/Users/prithamishra/Documents/dotnet";
        string fileName = "abc.txt";
        string fullPath = @$"{folderPath}/{fileName}";
        File.Create(fullPath);
    }
}