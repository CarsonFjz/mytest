using System;

namespace webtest {
    public class WeatherForecast {
        /// <summary>
        /// 时间
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }
        public string Value { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}