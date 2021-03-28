using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
namespace calculator
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        double num1 =0, num2 =0, result = 0;
        string op;

  

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            BunifuButton b = (BunifuButton)sender;
            if (result_label.Text == "0")
                result_label.Text="";

            if (ec)
            {
               
                result_label.Text = "";
               // result =Convert.ToDouble(result+ b.Text);
                ec = false;
            }

             result_label.Text = result_label.Text + b.Text;
            op_allow = true;
            op_clik = false;
            ec_allow = true;
        }
        bool op_allow = false;
        bool op_clik=false;

        private void Clear_Click(object sender, EventArgs e)
        {
            result_label.Text = tmp_label.Text = op = "";
            num1 = num2 = result = 0;
            op_allow =ec= false;
            ec_allow = true;
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            if (op_allow)
            {
                string op_new;
                BunifuButton bb = (BunifuButton)sender;
                op_new = bb.Text;



                if (op_clik)
                {
                    if (op != op_new)
                    {
                        tmp_label.Text =  op_new + " " + num1;
                        op = op_new;
                        result_label.Text="";
                        op_clik = true;
                    }

                }

                else
                {
                    if (ec)
                    {

                        result_label.Text = "";
                        ec = false;
                    }
                    else
                    {
                        num2 = Convert.ToDouble(result_label.Text);

                        if (num1 != 0)
                        {
                            switch (op)
                            {
                                case "+":
                                    num1 = num1 + num2;
                                    break;
                                case "-":
                                    num1 = num1 - num2;
                                    break;
                                case "x":
                                    num1 = num1 * num2;
                                    break;
                                case "÷":
                                    num1 = num1 / num2;
                                    break;
                            }
                        }
                        else
                        {
                            num1 = num1 + num2;
                        }
                    }
                    BunifuButton b = (BunifuButton)sender;
                    op = b.Text;

                    tmp_label.Text =  op + " " + num1;
                    result_label.Text = "";
                    //last_result = num1;
                    op_clik = true;
                    op_allow = true;
                    ec_allow = false;

                    //    op_tcheng = false;
                }
            }
            
        }
        bool ec_allow = false;
        bool ec=false;
        private void bunifuButton13_Click_1(object sender, EventArgs e)
        {

            if (ec_allow)
            {
               
                    num2 = Convert.ToDouble(result_label.Text);
                switch (op)
                {
                    case "+":
                        result = num1 + num2;

                        break;
                    case "-":
                        result = num1 - num2;

                        break;
                    case "x":
                        result = num1 * num2;

                        break;
                    case "÷":
                        result = num1 / num2;

                        break;
      
            }
                // num1 = result;
                num1 = result;
                tmp_label.Text = "";
    
                //if (ec)
                //{
                //    result_label.Text = result_label.Text;
                //}
                //else
                    result_label.Text = result.ToString();


                // num1 = result;
                op_allow = true;
                op_clik = false;
                ec = true;
                ec_allow = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (neddclare)
        //    {
        //        res_lable.Clear();
        //        neddclare = false;
        //    }
        //    res_lable.Text += "1";
            
        

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (neddclare)
        //    {
        //        res_lable.Clear();
        //        neddclare = false;
        //    }
        //    res_lable.Text += "2";
        //}

        //private void button3_Click(object sender, EventArgs e)
        ////{
        ////    if (neddclare)
        ////    {
        ////        res_lable.Clear();
        ////        neddclare = false;
        ////    }
        ////    res_lable.Text += "3";
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //if (neddclare)
        //    //{
        //    //    res_lable.Clear();
        //    //    neddclare = false;
        //    //}
        //    //res_lable.Text += "4";
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    //if (neddclare)
        //    //{
        //    //    res_lable.Clear();
        //    //    neddclare = false;
        //    //}
        //    //res_lable.Text += "5";
        //}

        //private void button4_Click(object sender, EventArgs e)
        ////{
        ////    if (neddclare)
        ////    {
        ////        res_lable.Clear();
        ////        neddclare = false;
        ////    }
        ////    res_lable.Text += "6";
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    //if (neddclare)
        //    //{
        //    //    res_lable.Clear();
        //    //    neddclare = false;
        //    //}
        //    //res_lable.Text += "7";
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        ////    if (neddclare)
        ////    {
        ////        res_lable.Clear();
        ////        neddclare = false;
        ////    }
        ////    res_lable.Text += "8";
        ////}

        ////private void button7_Click(object sender, EventArgs e)
        ////{

        ////    if (neddclare)
        ////    {
        ////        res_lable.Clear();
        ////        neddclare = false;
        ////    }
        ////    res_lable.Text += "9";
        //}

        //private void button14_Click(object sender, EventArgs e)
        //{

        ////    if (neddclare)
        ////    {
        ////        res_lable.Clear();
        ////        neddclare = false;
        ////    }
        ////    res_lable.Text += "0";
        ////}
        ////void renum1()
        ////{
        ////    if (start)
        ////        num1 = Convert.ToDouble(res_lable.Text);
        ////    else
        ////    {
        ////        switch (op)
        ////        {
        ////            case '+':
        ////                num1 = num1 + Convert.ToDouble(res_lable.Text);
        ////                break;
        ////            case '-':
        ////                num1 = num1 - Convert.ToDouble(res_lable.Text);
        ////                break;
        ////            case '*':
        ////                num1 = num1 * Convert.ToDouble(res_lable.Text);
        ////                break;
        ////            case '/':
        ////                num1 = num1 / Convert.ToDouble(res_lable.Text);
        ////                break;
        ////        }
        ////    }

        //}
        //private void button12_Click(object sender, EventArgs e)
        //{
        ////    op = '+';
        ////    if (!start)
        ////    {
               
        ////        renum1();
               
        ////    }
        ////    else
        ////        num1 = Convert.ToDouble(res_lable.Text);

        ////    res_lable.Clear();
        ////    start = false;
        //}

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    op = '-';
        //    if (!start)
        //    {
               
        //        renum1();
            
        //    }
        //    else
        //        num1 = Convert.ToDouble(res_lable.Text);
        //    res_lable.Clear();
        //    start = false;


        //}
        //string strnum2, laststrnum2;
        //private void button15_Click(object sender, EventArgs e)
        //{
        //    //start = true;
            
        //    //strnum2 = res_lable.Text;
        //    //if (strnum2 != null )
        //    //{
              
        //    //    num2 = Convert.ToDouble(res_lable.Text);
        //    //    switch (op)
        //    //    {
        //    //        case '+':
        //    //            result =num1+ num2;
        //    //            break;
        //    //        case '-':
        //    //                result = num1- num2;
        //    //            break;
        //    //        case '*':
        //    //            result = num1*  num2;
        //    //            break;
        //    //        case '/':
        //    //                result = num1/ num2;
        //    //            break;
        //    //    }
        //    //    res_lable.Text = result.ToString();
        //    //    op = '=';
        //    //}
        //    //else if (op == '=')
        //    //{
        //    //    res_lable.Text = result.ToString();
        //    //}
        //    //else
        //    //{
        //    //    res_lable.Text = "Input Error";
        //    //    neddclare = true;

        //    //}
        //    //num1 = num2 = 0;
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void button18_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void button17_Click(object sender, EventArgs e)
        //{
        //    result = 0;
        //    res_lable.Clear();

        //}

        //private void button16_Click(object sender, EventArgs e)
        //{

        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    op = '*';
        //    if (!start)
        //    {
              
        //        renum1();
           
        //    }
        //    else
        //        num1 = Convert.ToDouble(res_lable.Text);
        //    res_lable.Clear();
        //    start = false;


        //}

        //private void button13_Click(object sender, EventArgs e)
        //{
        //    op = '/';
        //    if (!start)
        //    {
        
        //        renum1();
           
        //    }
        //    else
        //        num1 = Convert.ToDouble(res_lable.Text);
        //    res_lable.Clear();
        //    start = false;

        //}
    }
}
