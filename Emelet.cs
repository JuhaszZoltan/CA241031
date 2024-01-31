namespace CA241031
{
    internal class Emelet
    {
        public string Nev { get; set; }
        public Dictionary<int, int> Szektorok  { get; set; }

        public override string ToString()
        {
            string str = $"{Nev,-10} | ";
            foreach (var kvp in Szektorok) str += $"{kvp.Value,3} | ";
            return str[..^3];
        }
            

        public Emelet(string sor)
        {
            var v = sor.Split("; ");
            Nev = v[0];
            Szektorok = new();
            for (int i = 1; i < v.Length; i++)
            {
                Szektorok.Add(i, int.Parse(v[i]));
            }
        }
    }
}
