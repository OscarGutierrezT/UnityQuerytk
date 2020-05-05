using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
namespace Roxy.core
{
    public class QueryResult
    {
        public bool isError = false;
        public string message = "";
        public JSONNode result = null;
    }
}