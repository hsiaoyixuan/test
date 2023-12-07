using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SimpleWordTest_comb_t : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
   
    protected void CBF110037_DDL1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedEValue = CBF110037_DDL1.SelectedValue;
        string selectedCValue = CBF110037_DDL1.SelectedItem.Text;
        CBF110037_cambridge.Text += selectedCValue + "→" + selectedEValue + "<br/>";
    }

    protected void CBF110037_NextButton_Click(object sender, EventArgs e)
    {
        int currentIndex = CBF110037_DDL1.SelectedIndex;
        int nextIndex = (currentIndex + 1) % CBF110037_DDL1.Items.Count;
        CBF110037_DDL1.SelectedIndex = nextIndex;
        string selectedEValue = CBF110037_DDL1.SelectedValue;
        string selectedCValue = CBF110037_DDL1.SelectedItem.Text;
        CBF110037_cambridge.Text = selectedCValue + "→" + selectedEValue + "<br/>";
    }

    protected void CBF110037_PreviousButton_Click(object sender, EventArgs e)
    {
        int currentIndex = CBF110037_DDL1.SelectedIndex;
        int nextIndex = (currentIndex - 1) % CBF110037_DDL1.Items.Count;
        CBF110037_DDL1.SelectedIndex = nextIndex;
        string selectedEValue = CBF110037_DDL1.SelectedValue;
        string selectedCValue = CBF110037_DDL1.SelectedItem.Text;
        CBF110037_cambridge.Text = selectedCValue + "→" + selectedEValue + "<br/>";
    }

    protected void CBF110037_NextButton_Click1(object sender, EventArgs e)
    {
        int currentIndex = CBF110037_DDL1.SelectedIndex;
        int nextIndex = (currentIndex + 1) % CBF110037_DDL1.Items.Count;
        CBF110037_DDL1.SelectedIndex = nextIndex;
        string selectedEValue = CBF110037_DDL1.SelectedValue;
        string selectedCValue = CBF110037_DDL1.SelectedItem.Text;
        CBF110037_cambridge.Text = selectedCValue + "→" + selectedEValue + "<br/>";
    }

    protected void CBF110037_PreviousButton_Click1(object sender, EventArgs e)
    {
        int currentIndex = CBF110037_DDL1.SelectedIndex;
        int nextIndex = (currentIndex - 1) % CBF110037_DDL1.Items.Count;
        CBF110037_DDL1.SelectedIndex = nextIndex;
        string selectedEValue = CBF110037_DDL1.SelectedValue;
        string selectedCValue = CBF110037_DDL1.SelectedItem.Text;
        CBF110037_cambridge.Text = selectedCValue + "→" + selectedEValue + "<br/>";
    }

    protected void CBF110037_testBtn_Click(object sender, EventArgs e)
    {
        CBF110037_MV1.ActiveViewIndex = 1;

        DisplayRandomWordFromDropDownList();
    }
    protected void DisplayRandomWordFromDropDownList()
    {
        if (CBF110037_DDL1.Items.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(CBF110037_DDL1.Items.Count);
            ListItem selectedListItem = CBF110037_DDL1.Items[randomIndex];

            string chineseMeaning = selectedListItem.Value;

            CBF110037_ch_hint.Text = chineseMeaning;

            string englishWord = selectedListItem.Text;
            CBF110037_input.Text = $"{englishWord[0]}{new string('_', englishWord.Length - 1).Replace("_", " _")}";

        }
    }
    protected void CBF110037_nextQBtn_Click(object sender, EventArgs e)
    {

        DisplayRandomWordFromDropDownList();
    }
}