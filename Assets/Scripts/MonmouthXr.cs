
using UnityEngine;
// creating a Namespace or Library that I will be using it
// without conflict with other library or classes from differnt 
// library

namespace MonmouthXr
{
    // we are clereating MonmouthXr nameSpace, whereever we would like to use this
    // we will simply write using MonmouthXr, and we sould be able to access all the classes
    // and functions from this name space likw we do using unity
    public class Utilities
    {
        public static void PrintMcXr()
        {
            Debug.Log("MonmouthXr");
        }
    }
}

