using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientifice_Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        string operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, IKelvin;
        char iOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 i, range;
            Int64 ans = 1;
            results = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("10^" + txt.Text);
            range = (Int64)results;
            for (i = 1; i <= range; i++)
            {
                ans = ans * 10;
            }
            results = (double)ans;
            txt.Text = results.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qtanh = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("Tanh" + "(" + (txt.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            txt.Text = System.Convert.ToString(qtanh);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 248;
            txt.Width = 213;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 480;
            txt.Width = 442;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 810;
            txt.Width = 442;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 750;
            txt.Width = 440;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 850;
            txt.Width = 440;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txt.Text == "0") || (enter_value))
                txt.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txt.Text.Contains("."))
                    txt.Text = txt.Text + num.Text;
            }
            else
                txt.Text = txt.Text + num.Text;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Clear();
            results = 0;
            lbl.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(results!=0)
            {
                button36.PerformClick();
            }
                operation = b.Text;
                results = Double.Parse(txt.Text);
                lbl.Text = results + " " + operation;
                enter_value = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(operation=="+")
            {
                txt.Text = (results + Double.Parse(txt.Text)).ToString();
            }
            else if(operation=="-")
            {
                txt.Text = (results - Double.Parse(txt.Text)).ToString();
            }
            else if(operation=="MOD")
            {
                txt.Text = (results % Double.Parse(txt.Text)).ToString();
            }
            else if(operation=="*")
            {
                txt.Text = (results * Double.Parse(txt.Text)).ToString();
            }
            else if(operation=="/")
            {
                txt.Text = (results / Double.Parse(txt.Text)).ToString();
            }
            else if(operation=="Exp")
            {
                double i = Double.Parse(txt.Text);
                double q;
                q = (results);
                txt.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
            }
            lbl.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Int64 i, range;
            Int64 ans=1;
            results = Double.Parse(txt.Text);
            range = (Int64)results;
            for(i=1;i<=range;i++)
            {
                ans=ans*i;
            }
            results = (double)ans;
            txt.Text = results.ToString();
        }

        private void btnspace_Click(object sender, EventArgs e)
        {
            if(txt.Text.Length>0)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
            }
            if (txt.Text=="")
            {
                txt.Text = "0";
            }

        }

        private void piebutton_Click(object sender, EventArgs e)
        {
            txt.Text = "3.14159265358997623";
        }

        private void log_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("log" + "(" + (txt.Text) + ")");
            ilog = Math.Log10(ilog);
            txt.Text = System.Convert.ToString(ilog);
            
        }

        private void sqrtbutton_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("sqrt" + "(" + (txt.Text) + ")");
            ilog = Math.Sqrt(ilog);
            txt.Text = System.Convert.ToString(ilog);
        }

        private void sinhbutton_Click(object sender, EventArgs e)
        {
            double  qsinh = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("Sinh" + "(" + (txt.Text) + ")");
            qsinh = Math.Sinh(qsinh);
            txt.Text = System.Convert.ToString(qsinh);            
        }

        private void cosbutton_Click(object sender, EventArgs e)
        {
            double qcos = (Math.PI / 180) * (Double.Parse(txt.Text));
            lbl.Text = System.Convert.ToString("Cos" + "(" + (txt.Text) + ")");
            qcos = Math.Cos(qcos);
            txt.Text = System.Convert.ToString(qcos);
        }

        private void sinbutton_Click(object sender, EventArgs e)
        {
            double qsin = (Math.PI / 180) * (Double.Parse(txt.Text));
            lbl.Text = System.Convert.ToString("Sin" + "(" + (txt.Text) + ")");
            qsin = Math.Sin(qsin);
            txt.Text = System.Convert.ToString(qsin);
        }

        private void coshbutton_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("Cosh" + "(" + (txt.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            txt.Text = System.Convert.ToString(qcosh);
        }

        private void tanbutton_Click(object sender, EventArgs e)
        {
            double qtan = (Math.PI/180)*(Double.Parse(txt.Text));
            lbl.Text = System.Convert.ToString("Tan" + "(" + (txt.Text) + ")");
            qtan = Math.Tan(qtan);
            txt.Text = System.Convert.ToString(qtan);
        }

        private void binbutton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt.Text);
            lbl.Text = txt.Text;
            txt.Text = System.Convert.ToString(a, 2);
        }

        private void decbutton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt.Text);
            lbl.Text = txt.Text;
            txt.Text = System.Convert.ToString(a);
        }

        private void octbutton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt.Text);
            lbl.Text = txt.Text;
            txt.Text = System.Convert.ToString(a, 8);
        }

        private void hexbutton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt.Text);
            lbl.Text = txt.Text;
            txt.Text = System.Convert.ToString(a, 16);
        }

        private void buttonx2_Click(object sender, EventArgs e)
        {
            Int64 a = Int64.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("("+txt.Text + ")^2");
            a = a * a;
            txt.Text = System.Convert.ToString(a);
        }

        private void buttonx3_Click(object sender, EventArgs e)
        {
            Int64 a = Int64.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("("+txt.Text + ")^3");
            a = a * a * a;
            txt.Text = System.Convert.ToString(a);
        }

        private void invxbutton_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("1/" + txt.Text);
            a = (1 / a) * 1.00;
            txt.Text = System.Convert.ToString(a);
        }

        private void lnxbutton_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txt.Text);
            lbl.Text = System.Convert.ToString("ln" + "(" + (txt.Text) + ")");
            ilog = Math.Log(ilog);
            txt.Text = System.Convert.ToString(ilog);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if(iOperation=='C')
            {
                //Celsius to Fahrenheit
                iCelsius = float.Parse(txt.Text);
                lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
            }
            else if(iOperation=='F')
            {
                //Fahrenheit to Celsius
                iFahrenheit = float.Parse(txt.Text);
                lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
            }
            else if(iOperation=='K')
            {
                IKelvin = float.Parse(txt.Text);
                lblConvert.Text = (((((9 * IKelvin) / 5) + 32) + 273.15).ToString());
            }
        }

        private void rbCeltoFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFahtoCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbkel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCeltoFah.Checked = false;
            rbFahtoCel.Checked = false;
            rbkel.Checked = false;
        }

        private void txtConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
