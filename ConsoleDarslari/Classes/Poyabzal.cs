namespace ConsoleDarslari.Classes
{
    public class Poyabzal
    {
        public Poyabzal(int id, string name, string matoTuri)
        {
            Id = id;
            Name = name;
            MatoTuri = matoTuri;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MatoTuri { get; set; }


        public static string GetMatoturi(Poyabzal poyabzal)
        {
            return poyabzal.MatoTuri;
        }
    }
}
