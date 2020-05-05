using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Roxy.core
{
    [CreateAssetMenu(fileName = "QueryConfiguration", menuName = "ScriptableObjects/QueryConfiguration", order = 1)]
    public class QueryBaseConfiguration : ScriptableObject
    {
        public string urlQuery;
        public bool isTest;
        public string urlQueryTest = "http://localhost/wordpress/wp-json/ezvirtual/v1/";
    }
}