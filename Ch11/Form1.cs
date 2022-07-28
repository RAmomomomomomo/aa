namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbuid.Text ="��� : "+uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = "��� : " + txtName.Text;
            
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHP.Text;
            lbHp.Text = "���� ? :" + hp;
        }

        private void btnChkfrult1_Click(object sender, EventArgs e)
        {
            CheckBox[] chkfruits = { chkfrult1, chkfrult2, chkfrult3, chkfrult4, chkfrult5 };
            List<string> fruits = new List<string>();

            foreach (CheckBox chk in chkfruits)
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }
            lbFruitReshlt.Text = "��� : " + String.Join(",", fruits);
        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColor = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();

            foreach (CheckBox chk in chkColor)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }
            lbColorResult.Text = "���:" + String.Join(",", colors);

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}