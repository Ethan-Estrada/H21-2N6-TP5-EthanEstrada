using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaladeurMultiFormats
{
    public class ChansonWMA : Chanson
    {
        public override string Format => throw new NotImplementedException();

        public override void EcrireEntete(StreamReader pobjFichier)
        {
            throw new NotImplementedException();
        }

        public override void EcrireParoles(StreamWriter pobjFichier, string pParoles)
        {
            throw new NotImplementedException();
        }

        public override void LireEntete()
        {
            throw new NotImplementedException();
        }

        public override string LireParoles(StreamReader pobjFichier)
        {
            throw new NotImplementedException();
        }
    }
}
