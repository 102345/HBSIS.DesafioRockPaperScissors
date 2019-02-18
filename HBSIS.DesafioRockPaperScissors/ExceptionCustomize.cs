using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBSIS.DesafioRockPaperScissors
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string mensagem)
                                : base(mensagem)
        {

        }

    }


    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError(string mensagem)
                                : base(mensagem)
        {

        }

    }
}
