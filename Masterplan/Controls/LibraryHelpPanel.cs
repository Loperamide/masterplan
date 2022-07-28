using System.Collections.Generic;
using System.Windows.Forms;

using Masterplan.Tools;

namespace Masterplan.Controls
{
	partial class LibraryHelpPanel : UserControl
	{
		public LibraryHelpPanel()
		{
			InitializeComponent();

			Browser.DocumentText = get_html();
		}

		string get_html()
		{
			List<string> lines = HTML.GetHead(null, null, Session.Preferences.TextSize);

			lines.Add("<P>" + Session.I18N.LabelLibHelp1 + "</P>");

			lines.Add("<P><B>" + Session.I18N.LabelLibHelp2A + "</B> " + Session.I18N.LabelLibHelp2B + "</P>");

			lines.Add("<P><B>" + Session.I18N.LabelLibHelp3A + "</B> " + Session.I18N.LabelLibHelp3B + "</P>");

			lines.Add("<P><B>" + Session.I18N.LabelLibHelp4A + "</B> " + Session.I18N.LabelLibHelp4B + "</P>");

			lines.Add("<P><B>" + Session.I18N.LabelLibHelp5A + "</B> " + Session.I18N.LabelLibHelp5B + "</P>");

			return HTML.Concatenate(lines);
		}
	}
}
