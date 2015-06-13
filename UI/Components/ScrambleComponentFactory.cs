using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
	public class ScrambleComponentFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Scramble"; }
        }

        public string Description
        {
            get { return "Displays a random scramble each run."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Information; }
        }

        public IComponent Create(LiveSplitState state)
        {
			return new ScrambleComponent(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
            get { return "none"; }
        }

        public string UpdateURL
        {
            get { return "none"; }
        }

        public Version Version
        {
            get { return Version.Parse("1.0.0"); }
        }
    }
}
