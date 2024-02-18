using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.LinkLabel;

namespace DriverFinder;

public partial class MainForm : Form
{
    //private List<Driver> drivers;
    private BindingList<Driver> originalDrivers;
    private BindingList<Driver> drivers;
    private string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    private string csvFilePath => $@"{documentsFolder}\Drivers.csv";

    public MainForm()
    {
        // Create a new CSV if one doesn't already exist
        if (File.Exists(csvFilePath) == false)
        {
            MessageBox.Show($"Could not find Drivers.csv\nCreating {csvFilePath}");
            File.WriteAllText(csvFilePath, Driver.GetCsvHeader());
        }

        // Read the CSV and convert it to a list of drivers
        try
        {
            var lines = File.ReadLines(csvFilePath).ToList();
            drivers = new BindingList<Driver>(csvToDrivers(lines));
            originalDrivers = new BindingList<Driver>(csvToDrivers(lines));
        }
        catch (Exception e)
        {
            // The user might have Drivers.csv open in excel or something
            if (e.Message.Contains("because it is being used by another process."))
            {
                MessageBox.Show($"'Drivers.csv' is in use. Please close it and try again.");
                this.Close();
            }
        }

        // Initialize the form and bind the CSV data to table
        InitializeComponent();
        driverData.DataSource = drivers!;
    }

    public static List<Driver> csvToDrivers(List<string> lines)
    {
        var drivers = new List<Driver>();
        foreach (string line in lines)
        {
            try
            {
                var newDriver = Driver.FromCsv(line);
                drivers.Add(newDriver);
            }
            catch { /* Header will throw error */ }
        }
        return drivers;
    }

    public static List<string> driversToCsv(List<Driver> drivers)
    {
        var csv = new List<string>();
        foreach (Driver driver in drivers)
        {
            csv.Add(driver.ToCsv());
        }
        return csv;
    }

    private void filtersChanged(object sender, EventArgs e)
    {
        try
        {
            var current = decimal.Parse(currentText.Text);
            var voltageMax = decimal.Parse(voltageMaxTextBox.Text);
            decimal voltageMin;
            if (voltageMinTextBox.Text == "")
            {
                voltageMinTextBox.PlaceholderText = voltageMaxTextBox.Text;
                voltageMin = voltageMax;
            }
            else
            {
                voltageMin = decimal.Parse(voltageMinTextBox.Text);
            }
            decimal power;
            if (powerTextBox.Text == "")
            {
                power = voltageMax * current / 1000;
                powerTextBox.PlaceholderText = power.ToString();
            }
            else
            {
                power = decimal.Parse(powerTextBox.Text);
            }
            var validDriver = from driver in drivers
                              where
                            current <= driver.currentMax &&
                            current >= driver.currentMin &&
                            voltageMax <= driver.voltageMax &&
                            voltageMin >= driver.voltageMin &&
                            power <= driver.power
                              orderby driver.power
                              select driver;
            driverData.DataSource = validDriver.ToList();
        }
        catch { }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        currentText.Text = "";
        voltageMaxTextBox.Text = "";
        voltageMinTextBox.Text = "";
        voltageMinTextBox.PlaceholderText = "";
        powerTextBox.Text = "";
        powerTextBox.PlaceholderText = "";
        driverData.DataSource = drivers;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Check if any of the drivers have been changed
        // We don't need/want to do anything if nothing's been changed
        if (drivers.Count == originalDrivers.Count)
        {
            for (int i = 0; i < drivers.Count; i++)
            {
                var o = originalDrivers[i];
                var n = drivers[i];
                if  (
                    (o.Distributor == n.Distributor) && 
                    (o.PartNumber == n.PartNumber) &&
                    (o.Current == n.Current) &&
                    (o.Voltage == n.Voltage) &&
                    (o.Power == n.Power) &&
                    (o.Size == n.Size) &&
                    (o.Mounting == n.Mounting) &&
                    (o.Feed == n.Feed) &&
                    (o.Dimming == n.Dimming))
                {
                    if (i == drivers.Count - 1) { return; }
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        // This prompt only apprears if something has been changed
        DialogResult res = MessageBox.Show(
            "It looks like you've made changes to some of your drivers.\n" +
            "Would you like to save these changes?",
            "Save Changes",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Stop);

        switch (res) {
            case DialogResult.Yes:
                var lines = new List<string>()
                {
                    Driver.GetCsvHeader()
                };
                lines.AddRange(driversToCsv(drivers.ToList()));
                File.WriteAllLines(csvFilePath, lines);
                break;
            case DialogResult.No:
                break;
            case DialogResult.Cancel:
                e.Cancel = true;
                break;
        }
    }
}
