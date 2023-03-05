namespace CSESPORT
{
    public partial class Form1 : Form
    {
        Player _newPlayer;
        public int iAge;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, int iAge)
        {
            
        }
        public Player GetPlayer() { return _newPlayer; }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastName.Text;
            string studentid = tbStudent_id.Text;
            string mail = tbMail.Text;
            string phone = tbPhone.Text;
            string major = tbMajor.Text;
            string displayname = tbDisplayName.Text;

            try
            {
                string age = tbAge.Text;
                int V = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            _newPlayer = new Player(name, lastname, studentid, mail, major, phone, displayname,iAge);

            this.DialogResult = DialogResult.OK;
        }
    }
}