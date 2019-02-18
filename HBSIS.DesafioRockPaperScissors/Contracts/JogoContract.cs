
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HBSIS.DesafioRockPaperScissors.Contracts
{
//    [DataContract]
    public class JogoContract
    {   
        //[DataMember]
        public IEnumerable<Jogo> jogos { get; set; }
    }
}
