using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercator.RegexTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MatchButton_Click(object sender, EventArgs e)
        {
            var error = "";
            var pattern = PatternTextBox.Text.Trim();
            var source = SourceTextBox.Text.Trim();
            try
            {
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(source);

                if (match.Success)
                {
                    ResultTextBox.Clear();

                    while (match.Success)
                    {
                        var groups = match.Groups;

                        foreach (Group group in groups)
                            ResultTextBox.AppendText(group.Value + Environment.NewLine);

                        match = match.NextMatch();
                    }
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                if (!string.IsNullOrEmpty(error))
                    MessageBox.Show(error,"异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            form.Show();
        }
    }
}
