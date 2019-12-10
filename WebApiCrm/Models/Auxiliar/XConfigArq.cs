using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq.Expressions;

namespace WebApiCrm.Models.Auxiliar
{
    public class XConfigArq
    {
        public XConfigArq() { }
        
        public static string Get<TProperty>(Expression<Func<TProperty>> pProperty)
        {
            MemberExpression member;
            member = (MemberExpression)pProperty.Body;
            return Get(member.Member.Name);
        }

        private static string Get(string pPropertyName)
        {
            var fileJson = File.ReadAllText("configuracoes.json");
            var objetoJson = JObject.Parse(fileJson);
            return objetoJson.SelectToken(pPropertyName).Value<string>();
        }
    }
}
