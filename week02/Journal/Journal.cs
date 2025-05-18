public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}
