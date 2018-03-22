using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta5.Models
{
    interface IConcecta<T>
    {
        bool CheckWin();
        void BuildBoard(T[,] board);
        T[,] Move(T valor);
    }
}
