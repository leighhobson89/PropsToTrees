using System;
using ICities;
using UnityEngine;

namespace PropsToTrees
{
    public class PropsToTrees : IUserMod
    {
        public string Name
        {  
            get { return "PropsToTrees"; }
        }

        public string Description
        {
            get { return "My first mode to convert Props to Trees"; }
        }
    }
}
