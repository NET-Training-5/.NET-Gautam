class EntryPoint
{
    public static void Main()
    {
        //FiFa worldcup2020 = new();
        //worldcup2020.host = "";
        //worldcup2020.year = new DateTime(2018, 2, 3);
        //worldcup2020.winner = "France";
        //worldcup2020.teams = new string[] {"France", "Germany", "Brazil"};

        //FiFa worldcup2022 = new("Qatar");
        MakeDirectory df = new();
        df.CreateTenDirectories();
    }
}