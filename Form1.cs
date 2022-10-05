namespace Tugas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSuhu.Focus();
            comboSuhu.SelectedText = "Pilih Suhu";
            txtHasil.ReadOnly = true; 
        }

        private void txtSuhu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSuhu.Text, "[^0-9]"))
            {
                MessageBox.Show("Hanya bisa dimasukan angka.");
                txtSuhu.Text = txtSuhu.Text.Remove(txtSuhu.Text.Length - 1);
            }
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            if (txtSuhu.Text == "")
            {
                MessageBox.Show("Nilai suhu tidak boleh kosong!!");
                return;
            }

            String selected = comboSuhu.Text;
            if (selected == "Pilih Suhu" || (rbCelcius.Checked || rbFahrenheit.Checked || rbReamur.Checked) == false)
            {
                MessageBox.Show("Harap pilih suhu terlebih dahulu!!");
            }

            float hasil = 0;
            float suhu;

            if (selected == "Celcius")
            {
                if (rbCelcius.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu;
                    txtHasil.Text = hasil.ToString() + "° " + rbCelcius.Text;
                }

                if (rbFahrenheit.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu * 9 / 5 + 32;
                    txtHasil.Text = hasil.ToString() + "° " + rbFahrenheit.Text;
                }

                if (rbReamur.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu * 4 / 5;
                    txtHasil.Text = hasil.ToString() + "° " + rbReamur.Text;
                }
            }

            if (selected == "Fahrenheit")
            {
                if (rbCelcius.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = (suhu - 32) * 5/9;
                    txtHasil.Text = hasil.ToString() + "° " + rbCelcius.Text;
                }

                if (rbFahrenheit.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu;
                    txtHasil.Text = hasil.ToString() + "° " + rbFahrenheit.Text;
                }

                if (rbReamur.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = (suhu - 32) * 4 / 9;
                    txtHasil.Text = hasil.ToString() + "° " + rbReamur.Text;
                }
            }

            if (selected == "Reamur")
            {
                if (rbCelcius.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu * 5 / 4;
                    txtHasil.Text = hasil.ToString() + "° " + rbCelcius.Text;
                }

                if (rbFahrenheit.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu * 9 / 4 + 32;
                    txtHasil.Text = hasil.ToString() + "° " + rbFahrenheit.Text;
                }

                if (rbReamur.Checked == true)
                {
                    suhu = float.Parse(txtSuhu.Text);
                    hasil = suhu;
                    txtHasil.Text = hasil.ToString() + "° " + rbReamur.Text;
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtSuhu.Text = "";
            comboSuhu.Text = "Pilih Suhu";
            rbCelcius.Checked = false;
            rbFahrenheit.Checked = false;
            rbReamur.Checked = false;
            txtHasil.Text = "";

        }
    }
}