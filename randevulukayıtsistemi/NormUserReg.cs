using System;
using ProjeSon.Data;
using ProjeSon.Logic;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class NormUserReg : Form
    {
        public NormUserReg()
        {
            InitializeComponent();
        }
        private readonly normekle normaladd = new normekle();

        private void normadd(string username, string password, string email, string name, string surname, string phone, string adress,int roletypeid)
        {
            NormUser normal = new NormUser
            {
                UserName = username,
                Password = password,
                Email = email,
                Name=name,
                SurName= surname,
                Phone=phone,
                Adress=adress,
                RoleTypeID=roletypeid

            };
            normaladd.ekle(normal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" )
            {

                MessageWarning wrn = new MessageWarning();
                wrn.Message = "BOS ALAN BIRAKMAYINIZ";
                wrn.DialogPush(wrn.Message);

            }
            
            else
            {

                normadd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, 3);
                MessageBox.Show("basarili");
                this.Hide();
                Login_Form login__Form = new Login_Form();
                login__Form.ShowDialog();
            }
        }


        public class MessageWarning : DialogCustom
        {

            public override void DialogPush(string Message)
            {
                MessageBox.Show(Message);
            }
        }



    }
}
