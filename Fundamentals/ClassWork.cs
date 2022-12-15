class MakeDirectory
{
    static string folderPath = @"/Users/prithamishra/Documents/dotnet";
    public void CreateTenDirectories()
    {
        Directory.CreateDirectory(folderPath);
        for (int i = 1; i < 11; i++)
        {
            string uniqueFolderPath = folderPath + "//Folder" + i;
            Directory.CreateDirectory(uniqueFolderPath);
            string myfile = @$"{uniqueFolderPath}/abc.txt";
            File.WriteAllText(myfile, $"I am in file {i}");        
        }
    }
}