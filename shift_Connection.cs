using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
using System.Xml;
using System.ServiceModel.Configuration;

namespace eChandanCanteen
{
    public partial class shift_Connection : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public shift_Connection()
        {
            InitializeComponent();
        }
        private void btnLan_Click(object sender, EventArgs e)
        {
            string[] key = { "eIM_ExPro_Inventory_WebServices"};
            string[] value = { "http://192.192.192.19/exprologic/Inventory_WebServices.asmx" };
            modify();
        }
        public static string GetServerName(string oldkey,string newkey)
        {
            string serverName = "Unknown";
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ServiceModelSectionGroup serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig);
            BindingsSection bindings = serviceModel.Bindings; 
            ChannelEndpointElementCollection endpoints=serviceModel.Client.Endpoints; 
            for (int i = 0; i < endpoints.Count; i++)
            {
                ChannelEndpointElement endpointElement = endpoints[i];
                Uri URI = new Uri("http://localhost/expro/Inventory_WebServices.asmx");
                if (endpointElement.Address ==URI)
                { 
                    serverName = endpointElement.Address.Host; 
                } 
            } 
            return serverName;
         }
        public void  modify()
        {
            //ClientSection clientSection = ConfigurationManager.GetSection("system.serviceModel/client") as ClientSection;
            //ChannelEndpointElementCollection endpointCollection = clientSection.ElementInformation.Properties[string.Empty].Value as ChannelEndpointElementCollection; 
            //List<string> endpointNames = new List<string>();
            //foreach (ChannelEndpointElement endpointElement in endpointCollection) 
            //{
            //   // endpointNames.Add(endpointElement.Address.ToString);
            //}
            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //ServiceModelSectionGroup serviceModel = ServiceModelSectionGroup.GetSectionGroup(config);
            //SettingElementCollection settingElements = (SettingElementCollection)serviceModel.SectionGroups;
            //SettingElement element = settingElements.Get("SettingName");
            //element.Value.ValueXml.InnerText ="new value";
            //config.Save(ConfigurationSaveMode.Modified, true);
        }
        private void changeconfig(string[] key,string[] value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode settingsNode = doc.GetElementsByTagName("endpoint")[0];
            for (int i = 0; i < 1; i++)
            {
                XmlNode node = settingsNode.SelectSingleNode(typeof(eChandanCanteen.Properties.Settings).FullName + "/setting[@address='" + key[i] + "']");
                if (node != null)
                {
                    XmlNode valueNode = node.SelectSingleNode("value");
                    if (valueNode!=null)
                    {
                        valueNode.FirstChild.Value = value[i];
                    }
                }
                doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
            MessageBox.Show("Connection Successfully Configured");
        
        }
        private void btnSetAirtel_Click(object sender, EventArgs e)
        {

            string[] key = { "eIM_ExPro_Inventory_WebServices" };
            string[] value = { "http://122.160.111.70/exprologic/Inventory_WebServices.asmx" };
            changeconfig(key, value); 
        }
        private void btnSetTATA_Click_1(object sender, EventArgs e)
        {
            string[] key = { "eIM_ExPro_Inventory_WebServices" };
            string[] value = { "http://59.162.255.115/exprologic/Inventory_WebServices.asmx" };
            changeconfig(key, value);        
        }
  
      
    }
}