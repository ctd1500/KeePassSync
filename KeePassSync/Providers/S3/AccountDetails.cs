using System;
using System.Collections;
using System.Windows.Forms;
using Amazon;

namespace KeePassSync.Providers.S3
{
	public partial class AccountDetails : UserControl
	{
		public string AccessKey
		{
			get { return txtAccessKey.Text; }
			set { txtAccessKey.Text = value; }
		}

		public string SecretAccessKey
		{
			get { return txtSecretAccessKey.Text; }
			set { txtSecretAccessKey.Text = value; }
		}

		public string BucketName
		{
			get { return txtBucketName.Text; }
			set { txtBucketName.Text = value; }
		}
		public bool CreateBackups
		{
			get { return cbxDailyBackups.Checked; }
			set { cbxDailyBackups.Checked = value; }

		}

		public string RegionName
		{
			get { return regionBox.SelectedValue.ToString(); }
			set { regionBox.SelectedValue = value; }
		}

		public AccountDetails()
		{
			InitializeComponent();

			RegionsArr.Add(new Regions(RegionEndpoint.USEast1.DisplayName, RegionEndpoint.USEast1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.USWest2.DisplayName, RegionEndpoint.USWest2.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.USWest1.DisplayName, RegionEndpoint.USWest1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.EUWest1.DisplayName, RegionEndpoint.EUWest1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.EUCentral1.DisplayName, RegionEndpoint.EUCentral1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.APSoutheast1.DisplayName, RegionEndpoint.APSoutheast1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.APNortheast1.DisplayName, RegionEndpoint.APNortheast1.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.APSoutheast2.DisplayName, RegionEndpoint.APSoutheast2.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.APNortheast2.DisplayName, RegionEndpoint.APNortheast2.SystemName));
			RegionsArr.Add(new Regions(RegionEndpoint.SAEast1.DisplayName, RegionEndpoint.SAEast1.SystemName));

			regionBox.DataSource = RegionsArr;
			regionBox.DisplayMember = "LongName";
			regionBox.ValueMember = "ShortName";
		}

		public ArrayList RegionsArr = new ArrayList();

		private void AccountDetails_Load(object sender, EventArgs e) {
			
		}

		public class Regions {
			private string shortName;
			private string longName;

			public Regions(string strLongName, string strShortName) {
				this.shortName = strShortName;
				this.longName = strLongName;
			}

			public string ShortName
			{
				get
				{
					return shortName;
				}
			}

			public string LongName
			{
				get
				{
					return longName;
				}
			}
		}

		private void regionBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (regionBox.SelectedIndex != -1) {
				RegionName = regionBox.SelectedValue.ToString();
				// If we also wanted to get the displayed text we could use
				// the SelectedItem item property:
				// string s = ((USState)ListBox1.SelectedItem).LongName;
			}
		}
	}
}
