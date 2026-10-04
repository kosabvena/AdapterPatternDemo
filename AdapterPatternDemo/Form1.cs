namespace AdapterPatternDemo
{
    public partial class Form1 : Form
    {
        private readonly LegacyFahrenheitSensor _legacySensor = new LegacyFahrenheitSensor();
        private readonly ITemperatureSensor _adaptedSensor;

        public Form1()
        {
            InitializeComponent();
            _adaptedSensor = new SensorAdapter(_legacySensor);
        }

        private void btnReadLegacy_Click(object sender, EventArgs e)
        {
            double f = _legacySensor.ReadFahrenheit();
            lstResults.Items.Add($"[Legacy]  ReadFahrenheit() = {f:F1} °F");
        }

        private void btnReadAdapted_Click(object sender, EventArgs e)
        {
            double c = _adaptedSensor.GetTemperatureCelsius();
            lstResults.Items.Add($"[Adapter] GetTemperatureCelsius() = {c:F1} °C");
        }
    }
}
