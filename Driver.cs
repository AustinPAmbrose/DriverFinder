using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DriverFinder;

public class Driver
{
    // Internals
    internal decimal power { get; set; }
    internal decimal currentMin { get; set; } // mA
    internal decimal currentMax { get; set; } // mA
    internal decimal voltageMin { get; set; }
    internal decimal voltageMax { get; set; }
    internal decimal length { get; set; }
    internal decimal width { get; set; }
    internal decimal height { get; set; }

    // Externals
    public string Distributor { get; set; } = "[New Driver]";
    public string PartNumber { get; set; } = "";
    public string Current
    {
        get
        {
            if (currentMin == currentMax)
            {
                return $"{currentMin}";
            } else
            {
                return $"{currentMin} - {currentMax}";
            }
        }
        set
        {
            try
            {
                var buf = value.Split('-');
                if (buf.Length == 1)
                {
                    currentMin = decimal.Parse(buf[0]);
                    currentMax = decimal.Parse(buf[0]);
                }
                else
                {
                    currentMin = decimal.Parse(buf[0]);
                    currentMax = decimal.Parse(buf[1]);
                }
            }
            catch {}
        }
    }
    public string Voltage 
    {
        get
        {
            if (voltageMin == voltageMax)
            {
                return $"{voltageMin}";
            }
            else
            {
                return $"{voltageMin} - {voltageMax}";
            }
        }
        set
        {
            try
            {
                var buf = value.Split('-');
                if (buf.Length == 1)
                {
                    voltageMin = decimal.Parse(buf[0]);
                    voltageMax = decimal.Parse(buf[0]);
                }
                else
                {
                    voltageMin = decimal.Parse(buf[0]);
                    voltageMax = decimal.Parse(buf[1]);
                }
            }
            catch {}
        }
    }
    public string Power
    {
        get => $"{power}";
        set
        {
            try
            {
                power = decimal.Parse(value);
            }
            catch { }
        }
    }
    public string Size
    {
        get => $"{length} x {width} x {height}";
        set
        {
            try
            {
                var buf = value.Split("x");
                length = decimal.Parse(buf[0]);
                width = decimal.Parse(buf[1]);
                height = decimal.Parse(buf[2]);
            }
            catch { }

        }
    }
    public string  Mounting { get; set; }
    public string Feed { get; set; }
    public string Dimming { get; set; } = "";

    public static string GetCsvHeader()
    {
        return
            "Distributor,PartNumber,power,currentMin," +
            "currentMax,voltageMin,voltageMax,length," +
            "width,height,Mounting,Feed,Dimming";
    }
    public static Driver FromCsv(string csv)
    {
        string[] strings = csv.Split(',');
        var newDriver         = new Driver();
        newDriver.Distributor = strings[0].Trim();
        newDriver.PartNumber  = strings[1].Trim();
        newDriver.power       = decimal.Parse(strings[2]);
        newDriver.currentMin  = decimal.Parse(strings[3]);
        newDriver.currentMax  = decimal.Parse(strings[4]);
        newDriver.voltageMin  = decimal.Parse(strings[5]);
        newDriver.voltageMax  = decimal.Parse(strings[6]);
        newDriver.length      = decimal.Parse(strings[7]);
        newDriver.width       = decimal.Parse(strings[8]);
        newDriver.height      = decimal.Parse(strings[9]);
        newDriver.Mounting    = strings[10].Trim();
        newDriver.Feed        = strings[11].Trim();
        newDriver.Dimming     = strings[12].Trim();
        return newDriver;
    }
    public string ToCsv()
    {
        return 
            $"{Distributor},{PartNumber},{power},{currentMin}," +
            $"{currentMax},{voltageMin},{voltageMax},{length}," +
            $"{width},{height},{Mounting},{Feed},{Dimming}";
    }

    public override string ToString()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(this, options);
    }
}
