using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            bool result = false;

            for (int i = 0; i < _identifiers.Count(); i++)
            {
                if (string.Equals(_identifiers[i], id, StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                }
            }
            return result;
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count > 0)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }

        public void AddId(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
    
}
