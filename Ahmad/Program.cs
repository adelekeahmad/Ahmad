// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmad;
class Program
{
    static void Main(string[] args)
    {
        Ahmad ahmad = new Ahmad();
        ahmad.name = "Paapy Jay";
        ahmad.age = 32;
        ahmad.complexion = "dark";
        ahmad.nationality = "Nigerian";
        ahmad.height = 65;
        ahmad.weight = 100;
        ahmad.religion = "islam";
        ahmad.ethnicity = "yoruba";
        ahmad.handsome = true;
        Console.WriteLine(ahmad.name + " is a " + ahmad.complexion + " guy " + "whose age is " + ahmad.age + " and " + "height is " + ahmad.height + ".");
        Console.ReadLine();
    }
    
}
