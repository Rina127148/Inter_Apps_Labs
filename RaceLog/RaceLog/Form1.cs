namespace RaceLog
{
    public partial class Form1 : Form
    {
        // Учебный круг: от 1/2 минуты до 10 минут
        private const int MinLapSeconds = 30;
        private const int MaxLapSeconds = 600;
        public Form1()
        {
            InitializeComponent();
            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string driver = txtDriver.Text.Trim();
            if (driver.Length == 0)
            {
                ShowError("Введите имя пилота");
                txtDriver.Focus();
                return;
            }
            if (cmbCar.SelectedIndex < 0 || cmbTrack.SelectedIndex < 0)
            {
                ShowError("Выберите автомобиль и трассу");
                return;
            }
            string timeText = txtTime.Text.Trim();
            bool valid = int.TryParse(timeText, out int seconds);
            if (!valid)
            {
                ShowError("Время должно быть целым числом");
                txtTime.Focus();
                return;
            }
            if (seconds < MinLapSeconds || seconds > MaxLapSeconds)
            {
                ShowError($"Время должно быть от {MinLapSeconds} до {MaxLapSeconds} с");
                txtTime.Focus();
                return;
            }
            string record = $"{driver} | {cmbCar.Text} | {cmbTrack.Text} | {seconds} с";
            lstResults.Items.Add(record);

            ClearInput();
            lblStatus.Text = $"добавлено. всего записей: {lstResults.Items.Count}";
        }

        private void ClearInput()
        {
            txtDriver.Clear();
            txtTime.Clear();
            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;
            txtDriver.Focus();
        }

        private void lblDriver_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            lblStatus.Text = "Поля очищены. Результаты сохранены в списке";
        }

        private void ShowError(string message)
        {
            lblStatus.Text = message;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstResults.SelectedIndex;
            if (index < 0)
            {
                ShowError("Сначала выберите запись в списке");
                return;
            }
            lstResults.Items.RemoveAt(index);
            lblStatus.Text = $"Запись удалена. Всего записей: {lstResults.Items.Count}";
        }

    }
}
