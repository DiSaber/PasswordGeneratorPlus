namespace PasswordGeneratorPlus
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            RandomPassword();
        }

        private void GenerateButton_Clicked(object sender, EventArgs e)
        {
            RandomPassword();
        }

        private void PasswordLength_TextChanged(object sender, EventArgs e)
        {
            RandomPassword();
        }

        private void CharacterSet_TextChanged(object sender, EventArgs e)
        {
            RandomPassword();
        }

        private void DefaultButton_Clicked(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void ResetSettings()
        {
            PasswordLength.Text = "20";
            CharacterSet.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!|%@#*$_+=";
        }

        private void RandomPassword()
        {
            if (int.TryParse(PasswordLength.Text, out int length))
            {
                PasswordBox.Text = RandomPassword(length);
            } else
            {
                PasswordBox.Text = RandomPassword(20);
            }
        }

        private string RandomPassword(int length)
        {
            string password = "";

            if (CharacterSet.Text.Length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    password += CharacterSet.Text[(int)random.Next(CharacterSet.Text.Length)];
                }
            }

            return password;
        }
    }
}
