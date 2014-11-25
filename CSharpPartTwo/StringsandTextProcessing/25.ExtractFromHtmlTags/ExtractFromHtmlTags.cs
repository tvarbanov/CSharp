using System;

class ExtractFromHtmlTags
{
    //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

    static void Main()
    {
        string html = "<html><head><title>News</title></head><body><p>textxtex</p></body>";
        int indexClosing = html.IndexOf('>');
        while (indexClosing > -1)
        {
            if (indexClosing < html.Length - 1 && html[indexClosing + 1] != '<')
            {
                int nextOpeningIndex = html.IndexOf('<', indexClosing);
                int textLength = nextOpeningIndex - indexClosing - 1;
                Console.WriteLine(html.Substring(indexClosing + 1, textLength));
            }
            indexClosing = html.IndexOf('>', indexClosing + 1);
        }
    }
}
