namespace TheMachineACafeClient
{
    using System;
    using System.Windows.Forms;
    using MachineServiceRef;

    public partial class MainForm : Form
    {
        private MachineServiceClient serviceClient;
        private int volumeSucre = 0;

        public MainForm()
        {
            InitializeComponent();           

            this.serviceClient = new MachineServiceClient();

            var boissons = this.serviceClient.GetListBoisson();

            this.comboBoxTypeBoisson.Items.AddRange(boissons);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string numBadde = this.textNumBadge.Text;

            bool numBadgeExist = this.serviceClient.ValidateNumBadge(numBadde);

            if (!numBadgeExist)
            {
                MessageBox.Show("Numero de badge invalide. Veuillez réseeayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var userPreferences = this.serviceClient.GetUserPreferences(numBadde);

                this.comboBoxTypeBoisson.SelectedItem = userPreferences.TypeBoisson;
                this.labelVolumeSucre.Text = userPreferences.QuantiteSucre == null ? "0" : userPreferences.QuantiteSucre.ToString();

                this.checkBoxUserMug.Checked = userPreferences.UseMug;

                volumeSucre = userPreferences.QuantiteSucre == null ? 0 : userPreferences.QuantiteSucre.Value;

                this.panelMachine.Enabled = true;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (volumeSucre <= 3)
            {
                volumeSucre++;
                labelVolumeSucre.Text = volumeSucre.ToString();
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (volumeSucre > 0)
            {
                volumeSucre--;

                labelVolumeSucre.Text = volumeSucre.ToString();
            }
        }

        private void buttonPrepareCafe_Click(object sender, EventArgs e)
        {
            UserPreferences userPreferences = new UserPreferences();

            userPreferences.NumBadge = this.textNumBadge.Text;
            userPreferences.TypeBoisson = this.comboBoxTypeBoisson.SelectedItem.ToString();
            userPreferences.QuantiteSucre = int.Parse(this.labelVolumeSucre.Text);
            userPreferences.UseMug = this.checkBoxUserMug.Checked;

            this.serviceClient.SetUserPreferences(userPreferences);

            this.pictureBoxCafe.Visible = true;
        }
    }
}
