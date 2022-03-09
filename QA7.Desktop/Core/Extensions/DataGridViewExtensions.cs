using System.Drawing;
using System.Windows.Forms;

namespace QA7.Desktop.Core.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void ConfigureDefault(this DataGridView gv)
        {
            gv.DefaultCellStyle.Font = new Font("Arial", 9);
            gv.RowTemplate.Height = 25;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gv.BorderStyle = BorderStyle.None;
            gv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gv.ColumnHeadersVisible = true;
            gv.RowHeadersVisible = false;
            gv.AllowUserToResizeColumns = false;
            gv.RowsDefaultCellStyle.BackColor = Color.Silver;
            gv.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            gv.AllowUserToResizeRows = true;
            gv.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
            gv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            gv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            gv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            gv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.AutoResizeColumns();
            gv.ScrollBars = ScrollBars.Both;
            gv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            var style = gv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Navy;
            style.ForeColor = Color.White;
            style.Font = new Font(gv.Font, FontStyle.Bold);

        }

        public static void FormatAnalysis(this DataGridView dgv)
        {
            var color = new Color();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                switch (dr.Cells["CallTagID"].Value)
                {
                    case 0:
                        color = Color.MintCream;
                        break;
                    case 1:
                        color = Color.YellowGreen;
                        break;
                    case 2:
                        color = Color.Gold;
                        break;
                    case 3:
                        color = Color.Peru;
                        break;
                    case 4:
                        color = Color.YellowGreen;
                        break;
                    case 5:
                        color = Color.Firebrick;
                        break;
                    case 6:
                        color = Color.PaleVioletRed;
                        break;
                    case 7:
                        color = Color.Coral;
                        break;
                    case 8:
                        color = Color.Salmon;
                        break;
                    case 9:
                        color = Color.OrangeRed;
                        break;
                    default:
                        break;
                }

                dr.Cells["CallTag"].Style.BackColor = color;
                dr.Cells["Filename"].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dgv.Columns["CallTag"].HeaderText = "Call Tag";
            dgv.Columns["HighestQualityPriority"].HeaderText = "Highest Quality Priority";
            dgv.Columns["FinalQualityPriority"].HeaderText = "Final Quality Priority";
        }
    }
}
