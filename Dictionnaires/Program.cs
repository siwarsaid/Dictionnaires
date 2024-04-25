namespace Dictionnaires
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<char,string> dic = new Dictionary<char,string>();
            dic.Add('a', "fraise");
            dic.Add('b', "banane");
            dic.Add('c', "pomme");
            dic.Remove('c');
            
        }
    }
}
