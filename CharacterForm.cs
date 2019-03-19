using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Mercator.RegexTester
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            var table = new DataTable();
            var columns = new List<DataColumn>()
            {
                new DataColumn("字符", Type.GetType("System.String")),
                new DataColumn("描述", Type.GetType("System.String")),
            };
            table.Columns.AddRange(columns.ToArray());

            var document = new XmlDocument();
            document.Load(string.Format("{0}characters.xml", AppDomain.CurrentDomain.BaseDirectory));
            var documentElement = document.DocumentElement;
            var characterNodes = documentElement.SelectNodes("./character");
            foreach (XmlNode characterNode in characterNodes)
            {
                var row = table.NewRow();
                table.Rows.Add(row);
                row["字符"] = characterNode.Attributes["name"].InnerText;
                row["描述"] = characterNode.InnerText;
            }

            XMLDataGridView.DataSource = table;

            for (int i = 0; i < XMLDataGridView.Columns.Count; i++)
            {
                XMLDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                XMLDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                if (i != 1) { XMLDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
            }
        }
    }
}
