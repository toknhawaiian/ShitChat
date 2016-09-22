using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShitChat.Domain;

namespace ShitChat.Repository
{
    public class ShitChatUserAssociation : IShitChatUserAssociation
    {
        public ShitChatUserAssociation()
        {
            dictionary = new BiDictionaryOneToOne<Guid, Guid>();
        }

        private BiDictionaryOneToOne<Guid, Guid> dictionary;
        public BiDictionaryOneToOne<Guid, Guid> Dictionary
        {
            get
            {
                return dictionary;
            }

            set
            {
                dictionary = value;
            }
        }
    }
}
