using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WinForms_Phone
{
    public partial class Phone : Form
    {

        public Phone()
        {
            InitializeComponent();

        }
        //Library library = new Library();
        public int i;
        public int k;
        public int t;
        public int click = 0;
        public int click2 = 1;

        public bool BigRu = false;
        public bool BigEn = false;

        public bool Ru = false;
        public bool En = true;
        public int EnOrRu = 0;

        public bool Number = false;

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void Hesh_Click(object sender, EventArgs e)
        {
            if (En == true)
            {
                if (BigEn == false)
                    BigEn = true;
                else if (BigEn == true)
                {
                    Ru = true;
                    En = false;
                    BigEn = false;
                }
            }
            else if (Ru == true)
            {
                if (BigRu == false)
                    BigRu = true;
                else if (BigRu == true)
                {
                    En = false;
                    Ru = false;
                    BigRu = false;
                    Number = true;
                }
            }
            else if(Number==true)
            {
                En = true;
                Number = false;
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {
            i = 0;
            litera(i);
        }

        private void abc2_Click(object sender, EventArgs e)
        {           
            i = 1;
            litera(i);
            
    }

        private void def3_Click(object sender, EventArgs e)
        {
            i = 2;
            litera(i);
        }

        private void ghi4_Click(object sender, EventArgs e)
        {
            i = 3;
            litera(i);
        }

        private void jkl5_Click(object sender, EventArgs e)
        {
            i = 4;
            litera(i);
        }

        private void mno6_Click(object sender, EventArgs e)
        {
            i = 5;
            litera(i);
        }

        private void pqrs7_Click(object sender, EventArgs e)
        {
            i = 6;
            litera(i);
        }

        private void tuv8_Click(object sender, EventArgs e)
        {
            i = 7;
            litera(i);
        }

        private void wxyz9_Click(object sender, EventArgs e)
        {
            i = 8;
            litera(i);
        }

        void litera(int n)
        {
            //if (n == 0)
            //{
            //    if (Number != true)
            //        n--;
            //}

            if (k != n)
            {
                click = 0;
                click2 = 1;
            }
            k = n;

           

            char[][] en = new char[16][];
            en[0] = new char[] { 'a', 'b', 'c' };
            en[1] = new char[] { 'd', 'e', 'f' };
            en[2] = new char[] { 'g', 'h', 'i' };
            en[3] = new char[] { 'j', 'k', 'l' };
            en[4] = new char[] { 'm', 'n', 'o' };
            en[5] = new char[] { 'p', 'q', 'r', 's' };
            en[6] = new char[] { 't', 'u', 'v' };
            en[7] = new char[] { 'w', 'x', 'y', 'z' };
            en[8] = new char[] { 'A', 'B', 'C' };
            en[9] = new char[] { 'D', 'E', 'F' };
            en[10] = new char[] { 'G', 'H', 'I' };
            en[11] = new char[] { 'J', 'K', 'L' };
            en[12] = new char[] { 'M', 'N', 'O' };
            en[13] = new char[] { 'P', 'Q', 'R', 'S' };
            en[14] = new char[] { 'T', 'U', 'V' };
            en[15] = new char[] { 'W', 'X', 'Y', 'Z' };

            char[][] ru = new char[16][];
            ru[0] = new char[] { 'а', 'б', 'в', 'г' };
            ru[1] = new char[] { 'д', 'е', 'ж', 'з' };
            ru[2] = new char[] { 'и', 'й', 'к', 'л' };
            ru[3] = new char[] { 'м', 'н', 'о', 'п' };
            ru[4] = new char[] { 'р', 'с', 'т', 'у' };
            ru[5] = new char[] { 'ф', 'х', 'ц', 'ч' };
            ru[6] = new char[] { 'ш', 'щ', 'ъ', 'ы' };
            ru[7] = new char[] { 'ь', 'э', 'ю', 'я' };
            ru[8] = new char[] { 'А', 'Б', 'В', 'Г' };
            ru[9] = new char[] { 'Д', 'Е', 'Ж', 'З' };
            ru[10] = new char[] { 'И', 'Й', 'К', 'Л' };
            ru[11] = new char[] { 'М', 'Н', 'О', 'П' };
            ru[12] = new char[] { 'Р', 'С', 'Т', 'У' };
            ru[13] = new char[] { 'Ф', 'Х', 'Ц', 'Ч' };
            ru[14] = new char[] { 'Ш', 'Щ', 'Ъ', 'Ы' };
            ru[15] = new char[] { 'Ь', 'Э', 'Ю', 'Я' };

            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            char[] starplus = new char[] { '*', '+' };
            
            char[] symbol = new char[] { ',', '.', '!', '?', '/', '@'};

            click++;
            if (Number == true && n<20)
            {
                display.Text += number[n];
            }
            else if (n > 0 && n < 10)
            {
                n--;

                if (BigRu == true || BigEn == true)
                    n += 8;

                if (En == true)
                {
                    if (n == 5 || n == 7 || n == 13 || n == 15)
                    {
                        if (click == 5)
                            click = 1;
                    }
                    else
                    {
                        if (click == 4)
                            click = 1;
                    }
                }
                else if (Ru == true)
                {
                    if (click == 5)
                        click = 1;
                }
                if (click2 > 1)
                    Backspace();
                if (En == true)
                    display.Text += en[n][click - 1];
                else if (Ru == true)
                    display.Text += ru[n][click - 1];
                click2 = 2;
            }
            else if (n == 0)
            {
                if (click == 7)
                    click = 1;
                if (click2 > 1)
                    Backspace();
                display.Text += symbol[click - 1];
                click2 = 2;
            }
            
            if (n == 20)
            {
                if (click == 3)
                    click = 1;
                if (click2 > 1)
                    Backspace();
                display.Text += starplus[click - 1];
                click2 = 2;
            }
            
        }

        public void Backspace()
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            Backspace();
        }

        private void StarPlus_Click(object sender, EventArgs e)
        {
            i = 20;
            litera(i);
        }

        private void ZeroSpace_Click(object sender, EventArgs e)
        {
            if (Number == false)
            {
                display.Text += " ";
                click2 = 1;
                click = 0;
            }
            else
                display.Text += '0';
        }
    }

}
