namespace articl;

using System;
using System.Text;
using System.Text.Json;

class Article
{
    public string Name { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    // TODO: Content setter sets `Updated' to `DateTime.Now'
    public string Content { get; set; }

    public Article(string name)
    {
        this.Name = name;
        this.Created = DateTime.Now;
        this.Updated = DateTime.Now;
        this.Content = "";
    }

    // TODO: Serialize `this' to JSON String
    private string ToJson()
    {
        return "";
    }

    // TODO: Test `Save'
    public void Save(string path)
    {
        FileStream fstream = File.OpenWrite(path);
        string thisJson = this.ToJson();

        fstream.Write(Encoding.ASCII.GetBytes(thisJson));
    }
}