using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{

    public class Logs
    {
        private static ILogFactory _logFactory = new NoOpLogFactory();

        /// <summary>
        /// 全局的LogFactory。默认为NoOpLogFactory。
        /// </summary>
        public static ILogFactory LogFactory { get { return _logFactory; } set { _logFactory = value; } }
    }
}
