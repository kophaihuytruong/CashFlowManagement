using CentosCashFlow.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CentosCashFlow.ChildForms
{
    public partial class ManageCurrencies : Form
    {
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public bool isChanged { get; set; }
        public ManageCurrencies()
        {
            InitializeComponent();
            userSettings = new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        private void Load_Data(bool isSearched)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);

            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            List<Models.Currency> list = new List<Models.Currency>();
            if (isSearched)
            {
                list = connectCurrency.getDataByNameOrID(textBoxSearch.Text);
            }
            else
            {
                list = connectCurrency.getData();
            }
            foreach (Models.Currency currency in list)
            {
                Panel newPanel = new Panel();
                panelCurrenciesLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                CurrencyItem item = new CurrencyItem();
                item.currency = currency;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data(bool isSearched)
        {
            foreach (Control control in panelCurrenciesLoad.Controls)
            {
                control.Dispose();
            }

            panelCurrenciesLoad.Controls.Clear();

            Load_Data(isSearched);
        }
        private void ManageCurrencies_Load(object sender, EventArgs e)
        {
            Load_Data(false);
        }

        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            CurrencyAddingForm form = new CurrencyAddingForm();
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data(false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Reload_Data(true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Reload_Data(false);
        }

        private void btnUpdateExchangeRate_Click(object sender, EventArgs e)
        {
            string link = "https://v6.exchangerate-api.com/v6/6309a649d17353828dd28b85/latest/USD";
            // Gọi hàm để lấy dữ liệu từ API
            try
            {
                // Gọi hàm để lấy dữ liệu từ API và trả về danh sách Currency
                List<Currency> currencies = GetCurrenciesFromApi(link);
                Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
                List<Models.Currency> list = new List<Models.Currency>();
                list = connectCurrency.getData();
                foreach (Models.Currency cur in list)
                {
                    // Lọc giá trị của key
                    Currency updateCurrencyValue = currencies.FirstOrDefault(currency => currency.CurrencyCode == cur.CurrencyCode);
                    if (updateCurrencyValue != null)
                    {
                        int kt = connectCurrency.updateExchangeRateByID(updateCurrencyValue.CurrencyCode, updateCurrencyValue.ExchangeRate);
                        if(kt !=0)
                        {
                            isChanged = true;
                        }
                    }
                }
                if (isChanged)
                {
                    Reload_Data(false);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private List<Currency> GetCurrenciesFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Gửi yêu cầu GET đến API và đọc nội dung của phản hồi đồng bộ
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    //Console.WriteLine(responseBody);
                    ExchangeRateApiResponse apiResponse = JsonConvert.DeserializeObject<ExchangeRateApiResponse>(responseBody);

                    Dictionary<string, decimal> conversionRates = apiResponse.ConversionRates;

                    List<Currency> currencies = conversionRates.Select(kv => new Currency
                    {
                        CurrencyCode = kv.Key,
                        ExchangeRate = kv.Value
                    }).ToList();

                    return currencies;
                }
                catch (HttpRequestException e)
                {
                    // Nếu có lỗi khi gọi API, ném ngoại lệ để xử lý ở nơi gọi
                    throw new Exception($"Error calling API: {e.Message}");
                }
            }
        }
        // Đối tượng mô hình
        public class Currency
        {
            public string CurrencyCode { get; set; }
            public decimal ExchangeRate { get; set; }
        }

        // Đối tượng mô hình cho phản hồi từ API
        public class ExchangeRateApiResponse
        {
            public string Result { get; set; }
            public string Documentation { get; set; }
            public string TermsOfUse { get; set; }
            public long TimeLastUpdateUnix { get; set; }
            public string TimeLastUpdateUtc { get; set; }
            public long TimeNextUpdateUnix { get; set; }
            public string TimeNextUpdateUtc { get; set; }
            public string BaseCode { get; set; }
            [JsonProperty("conversion_rates")]
            public Dictionary<string, decimal> ConversionRates { get; set; }
        }
    }
}
