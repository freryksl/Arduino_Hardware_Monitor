using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace ArduinoHardwareMonitor
{
    public partial class Form1 : Form
    {
        Computer comp;
        string selectedPort;
        HardwareType selectedHardware;
        ComboItem selectedSensorType;
        SerialPort serpt = new SerialPort();
        private bool status = false;
        public Form1()
        {
            InitializeComponent();
            comp = new Computer();
            comp.Open();
            comp.CPUEnabled = true;
            comp.GPUEnabled = true;
            foreach (var hardware in comp.Hardware)
            {
                comboHardware.Items.Add(hardware.HardwareType);
            }
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboComPort.Items.Add(port);
            }
        }

        public class ComboItem {
            public string text { get; set; }
            public string name { get; set; }
            public SensorType type { get; set; }
            public override string ToString()
            {
                return text;
            }
        }

        private void comboComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = comboComPort.SelectedItem.ToString();
            btnStart.Enabled = true;
        }

        private void comboHardware_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSensorType.Items.Clear();
            selectedHardware = (HardwareType) comboHardware.SelectedItem;
            foreach (var hardware in comp.Hardware)
            {
                if(hardware.HardwareType == selectedHardware)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        ComboItem item = new ComboItem();
                        item.text = String.Format("{0} - {1}", sensor.Name, sensor.SensorType);
                        item.name = sensor.Name;
                        item.type = sensor.SensorType;
                        comboSensorType.Items.Add(item);
                    }
                }
            }
            comboSensorType.Enabled = true;
        }

        private void comboSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSensorType = (ComboItem) comboSensorType.SelectedItem;
            comboComPort.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            comboComPort.Enabled = false;
            comboHardware.Enabled = false;
            comboSensorType.Enabled = false;
            serpt.BaudRate = 9600;
            serpt.PortName = selectedPort;
            serpt.Open();
            status = true;
            foreach (var hardware in comp.Hardware)
            {
                if (hardware.HardwareType == selectedHardware) 
                {
                    Task.Run(() => {
                        while (status)
                        {
                            hardware.Update();
                            foreach (var sensor in hardware.Sensors)
                            {
                                if (sensor.Name == selectedSensorType.name && sensor.SensorType == selectedSensorType.type 
                                && sensor.Value.HasValue)
                                {
                                    byte[] sensorVal = Encoding.UTF8.GetBytes(String.Format("{0} {1}: {2}",
                                           selectedSensorType.name.Substring(0, Math.Min(4, selectedSensorType.name.Length)),
                                           selectedSensorType.type.ToString().Substring(0, Math.Min(4, selectedSensorType.type.ToString().Length)),
                                           sensor.Value.GetValueOrDefault().ToString()));
                                    try 
                                    {                                      
                                        serpt.Write(sensorVal, 0, sensorVal.Length);
                                    }
                                    catch(Exception error)
                                    {
                                        Console.WriteLine(error);
                                    }
                                }
                            }
                            Thread.Sleep(2000);
                        }
                    });
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            status = false;
            serpt.Close();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            comboComPort.Enabled = true;
            comboHardware.Enabled = true;
            comboSensorType.Enabled = true;
        }

    }
}
