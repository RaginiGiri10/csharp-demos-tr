using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_COnstReadOnlyExample
{
    public class ConstantExample
    {
        //const fields are static and must be initialized at the time of declaration.
        public const float pi =3.14f;
    }

    public class ReadOnlyExample
    {
        //Readonly fields are non static and can be initialized during declaration. Initialization can be done in constructors as well.
        public readonly float pi;

        public ReadOnlyExample()
        {
            pi = 3.14f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConstantExample constantExample = new ConstantExample();          
            Console.WriteLine(ConstantExample.pi);
            ReadOnlyExample readOnlyExample = new ReadOnlyExample();
            
            
        }
    }
}
