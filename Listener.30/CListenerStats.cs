using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener
{
	internal class CListenerStats
	{
		public const int MaxTxns = 10;
		public int counterTotal = 0;
		public int counterSinceLastStart = 0;
		public int counterValidMessages = 0;
		public int counterValidMessagesSinceLastStart = 0;
		public int counterInvalidMessages = 0;
		public int counterInvalidMessagesSinceLastStart = 0;
		public int counterProcessedMessages = 0;
		public int counterProcessedMessagesSinceLastStart = 0;
	}
}
