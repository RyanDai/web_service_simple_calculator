using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPageSeperated : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string first = FirstNumber.Text;
        string second = SecondNumber.Text;
        int firstNum = Convert.ToInt16(first);
        int secondNum = Convert.ToInt16(second);
        string operation = DropDownList1.SelectedItem.Value;
        int result = 0;
        if (operation.Equals("+"))
        {
            result = firstNum + secondNum;
        }
        if (operation.Equals("-"))
        {
            result = firstNum - secondNum;
        }
        if (operation.Equals("*"))
        {
            result = firstNum * secondNum;
        }
        if (operation.Equals("/"))
        {
            result = firstNum / secondNum;
        }
        BaseTenResult.Text = Convert.ToString(result);

        string binary = Convert.ToString(result,2);
        BaseTwoResult.Text = binary;
    }

    protected void Count_Click(object sender, EventArgs e)
    {
        string first = FirstNumber.Text;
        string second = SecondNumber.Text;
        int firstNum = Convert.ToInt16(first);
        int secondNum = Convert.ToInt16(second);
        string operation = DropDownList1.SelectedItem.Value;
        int result = 0;
        if (operation.Equals("+"))
        {
            result = firstNum + secondNum;
        }
        if (operation.Equals("-"))
        {
            result = firstNum - secondNum;
        }
        if (operation.Equals("*"))
        {
            result = firstNum * secondNum;
        }
        if (operation.Equals("/"))
        {
            result = firstNum / secondNum;
        }
        BaseTenResult.Text = Convert.ToString(result);

        string binary = Convert.ToString(result, 2);

        int countZero = 0;
        int countOne = 0;
        for(int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                countZero++;
            }
            if (binary[i] == '1')
            {
                countOne++;
            }
        }
        NumOfZero.Text = Convert.ToString(countZero);
        NumOfOne.Text = Convert.ToString(countOne);
    }
}