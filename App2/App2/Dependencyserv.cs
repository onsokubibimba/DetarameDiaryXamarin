using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public interface IDependencyserv
    {
            /// <summary>
            /// アプリ終了
            /// </summary>
            void Exit();
    }

    public interface IHelpMsg
    {
        void Show(string message);
    }
}
