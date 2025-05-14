using System;
using System.Collections;

class MusicCatalog
{
    private Hashtable catalog;

    public MusicCatalog()
    {
        catalog = new Hashtable();
    }

    
    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
        {
            catalog[diskName] = new ArrayList();
            Console.WriteLine($"Диск \"{diskName}\" добавлен в каталог.");
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" уже существует!");
        }
    }


    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            catalog.Remove(diskName);
            Console.WriteLine($"Диск \"{diskName}\" удалён из каталога.");
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не найден.");
        }
    }

   
    public void AddSong(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ((ArrayList)catalog[diskName]).Add(songName);
            Console.WriteLine($"Песня \"{songName}\" добавлена на диск \"{diskName}\".");
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не найден!");
        }
    }

   
    public void RemoveSong(string diskName, string songName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            if (songs.Contains(songName))
            {
                songs.Remove(songName);
                Console.WriteLine($"Песня \"{songName}\" удалена с диска \"{diskName}\".");
            }
            else
            {
                Console.WriteLine($"Песня \"{songName}\" не найдена на диске \"{diskName}\".");
            }
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не найден.");
        }
    }

   
    public void ViewCatalog()
    {
        Console.WriteLine("\nКаталог музыкальных дисков:");
        foreach (DictionaryEntry entry in catalog)
        {
            Console.WriteLine($"Диск: {entry.Key}");
            foreach (string song in (ArrayList)entry.Value)
            {
                Console.WriteLine($"  - {song}");
            }
        }
    }

    
    public void ViewDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            Console.WriteLine($"\nСодержимое диска \"{diskName}\":");
            foreach (string song in (ArrayList)catalog[diskName])
            {
                Console.WriteLine($"  - {song}");
            }
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не найден.");
        }
    }
}

class Program
{
    static void Main()
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Rock Classics");
        catalog.AddSong("Rock Classics", "Bohemian Rhapsody");
        catalog.AddSong("Rock Classics", "Hotel California");

        catalog.AddDisk("Pop Hits");
        catalog.AddSong("Pop Hits", "Thriller");
        catalog.AddSong("Pop Hits", "Like a Prayer");

        catalog.ViewCatalog();

        catalog.RemoveSong("Rock Classics", "Hotel California");
        catalog.ViewDisk("Rock Classics");

        catalog.RemoveDisk("Pop Hits");
        catalog.ViewCatalog();
    }
}
