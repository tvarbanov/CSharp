using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

class ParsingURL
{
    /*Write a program that parses an URL address given in the format:
        [protocol]://[server]/[resource]
		and extracts from it the [protocol], [server] and [resource] elements. 
        For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"*/

    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";

        Regex result = new Regex(@"^(?<prot>\w+)://(?<server>\w+\.?\w+\w+\.?\w+)(?<resource>\S+)");
        Match matches = result.Match(url);
        if (matches.Success)
            Console.WriteLine(result.Match(url).Result("[protocol] = " + "\"${prot}\"\n[server] = \"${server}\"\n[resource] = \"${resource}\"")); 
    }
}
