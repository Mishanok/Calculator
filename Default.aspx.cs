using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPFirst
{
    public partial class Default : System.Web.UI.Page
    {
        //public Action Write;

        private static bool IsChange = false;
        private static bool IsDouble = true;
        

        private string ind;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*foreach (var item in Controls) //обходим все элементы формы
            {
                if (item is Button && ((Button)item).ID != "ButEqv" && ((Button)item).ID != "ButAC") // проверяем, что это кнопка
                {
                    ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
                }
            } */
        }

        protected void CommonBtn_Click(object sender, EventArgs e)
        {
            if (IsDouble == false) { TextBoxMain.Text = ""; IsDouble = true; }
            if (!IsChange)
            {
                TextBoxMain.Text += ((Button)sender).Text;
                if (Manag.First == 0) Manag.First = Convert.ToDouble(((Button)sender).Text);
                else
                {
                    Manag.First *= 10;
                    Manag.First += Convert.ToDouble(((Button)sender).Text);
                }
            }
            if (IsChange)
            {
                TextBoxMain.Text += ((Button)sender).Text;
                if (Manag.Second == 0) Manag.Second = Convert.ToDouble(((Button)sender).Text);
                else
                {
                    Manag.Second *= 10;
                    Manag.Second += Convert.ToDouble(((Button)sender).Text);
                }
            }
                
        }

        protected void Meth_Click(object sender, EventArgs e)
        {
            IsChange = true;
            IsDouble = false;
            TextBoxMain.Text = "";
            Manag.ind = ((Button)sender).Text;
            TextBoxMain.Text = Manag.ind;
        }

       /* protected void Text_Changed(object sender, EventArgs e)
        {
            double res1;
            int lenght;
            double res2;
            if (!Double.TryParse(((TextBox)sender).Text, out res1))
            {
                Manag.First = res1;
                lenght = ((TextBox)sender).Text.Length;
                if (!Double.TryParse(((TextBox)sender).Text.Remove(0, lenght-1), out res2))
                {
                    Manag.Second = res2;
                }
            }
        } */

        protected void AC_Click(object sender, EventArgs e)
        {
            TextBoxMain.Text = "";
            LabelRes.Text = "";
            Manag.Clear();
            IsChange = false;
            IsDouble = true;
    }

        protected void ButEqv_Clicks(object sender, EventArgs e)
        {    //if (ind != String.Empty && Manag.First != 0 && Manag.Second != 0)
            try
            {
                double res;
                switch (Manag.ind)
                {
                    case "X":
                        res = Manag.First * Manag.Second;
                        LabelRes.Text = res.ToString();
                        break;
                    case "%":
                        res = Manag.First % Manag.Second;
                        LabelRes.Text = res.ToString();
                        break;
                    case "/":
                        res = Manag.First / Manag.Second;
                        LabelRes.Text = res.ToString();
                        break;
                    case "-":
                        res = Manag.First - Manag.Second;
                        LabelRes.Text = res.ToString();
                        break;
                    case "+":
                        res = Manag.First + Manag.Second;
                        LabelRes.Text = res.ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
                 
        }

        protected void ButDot_Click(object sender, EventArgs e)
        {
            
        }
    }
}                                       