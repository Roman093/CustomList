using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {

            var notebook = new CustomList();

            var name = new List<string>();
            var Igor = new Notebook(1, "Igor");
            var Vasia = new Notebook(2, "Vasia");
            var Kurlyk = new Notebook(3, "Kurlyk");

            notebook.Add(Igor);
            notebook.Add(Vasia);
            notebook.Add(Kurlyk);

            var pupkin = notebook[1];
            
            notebook.Delete(pupkin);

        }
    }
}






