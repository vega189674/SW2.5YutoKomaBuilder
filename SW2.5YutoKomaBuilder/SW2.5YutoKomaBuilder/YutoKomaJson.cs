using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SW2._5YutoKomaBuilder
{
    /// <summary>
    /// ココフォリアのコマ情報（Json形式）
    /// </summary>
    [JsonObject("YutoKomaJson")]
    public class YutoKomaJson
    {
        [JsonProperty("kind")]
        public string kind { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }

        public YutoKomaJson()
        {
            kind = "";
            data = new Data();
        }
    }

    /// <summary>
    /// コマのデータ部分
    /// </summary>
    public class Data
    {
        [JsonProperty("name")]
        public string c_name { get; set; }
        [JsonProperty("playerName")]
        public string p_name { get; set; }
        [JsonProperty("memo")]
        public string memo { get; set; }
        [JsonProperty("initiative")]
        public int initiative { get; set; }
        [JsonProperty("externalUrl")]
        public string externalUrl { get; set; }
        [JsonProperty("status")]
        public List<Status> statuses { get; set; }
        [JsonProperty("params")]
        public List<Parameter> parameters { get; set; }
        [JsonProperty("faces")]
        public List<object> faces { get; set; }
        [JsonProperty("x")]
        public int x { get; set; }
        [JsonProperty("y")]
        public int y { get; set; }
        [JsonProperty("z")]
        public int z { get; set; }
        [JsonProperty("angle")]
        public int angle { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
        [JsonProperty("active")]
        public bool active { get; set; }
        [JsonProperty("secret")]
        public bool secret { get; set; }
        [JsonProperty("invisible")]
        public bool invisible { get; set; }
        [JsonProperty("hideStatus")]
        public bool hideStatus { get; set; }
        [JsonProperty("color")]
        public string color { get; set; }
        [JsonProperty("roomId")]
        public object roomId { get; set; }
        [JsonProperty("commands")]
        public string commands { get; set; }
        [JsonProperty("speaking")]
        public bool speaking { get; set; }

        public Data()
        {
            c_name = "";
            p_name = "";
            memo = "";
            initiative = 0;
            externalUrl = "";
            statuses = new List<Status>();
            parameters = new List<Parameter>();
            faces = new List<object>();
            x = 0;
            y = 0;
            z = 0;
            width = 4;
            height = 4;
            active = true;
            secret = false;
            invisible = false;
            hideStatus = false;
            color = "";
            roomId = null;
            commands = "";
            speaking = true;


        }
    }

    /// <summary>
    /// コマ内部で使用されるステータス項目
    /// </summary>
    public class Status
    {
        [JsonProperty("label")]
        public string label { get; set; }
        [JsonProperty("value")]
        public string value { get; set; }
        [JsonProperty("max")]
        public string max { get; set; }

        public Status()
        {
            label = "";
            value = "";
            max = "";
        }

        public Status(string str)
        {
            label = str;
            value = "";
            max = "";
        }
        public Status(string str,string val)
        {
            label = str;
            value = val;
            max = val;
        }

    }

    /// <summary>
    /// コマ内部で使用されるパラメータ項目
    /// </summary>
    public class Parameter
    {
        [JsonProperty("label")]
        public string label { get; set; }
        [JsonProperty("value")]
        public string value { get; set; }
        public Parameter()
        {
            label = "";
            value = "";
        }
    }
}
