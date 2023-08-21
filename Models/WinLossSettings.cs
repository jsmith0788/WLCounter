using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalStreamTools.Models
{
    public class WinLossSettings
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public string FileSource { get; set; }
        public string PrefixText { get; set; }
        public string RankGroup { get; set; }
        public string RankNumber { get; set; }
    }
}
