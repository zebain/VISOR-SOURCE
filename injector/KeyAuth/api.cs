using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000002 RID: 2
	public class api
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				MessageBox.Show("Application not found.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			if (success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					Process.Start(response_structure.download);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002260 File Offset: 0x00000460
		public bool register(string username, string pass, string key)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002404 File Offset: 0x00000604
		public bool login(string username, string pass)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002590 File Offset: 0x00000790
		public void upgrade(string username, string key)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026FC File Offset: 0x000008FC
		public bool license(string key)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002874 File Offset: 0x00000A74
		public void ban()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002990 File Offset: 0x00000B90
		public string var(string varid)
		{
			bool flag = !this.initzalized;
			string result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = "";
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
				nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = "";
				}
				else
				{
					result = response_structure.message;
				}
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public void webhook(string webid, string param)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
				nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C40 File Offset: 0x00000E40
		public byte[] download(string fileid)
		{
			bool flag = !this.initzalized;
			byte[] result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = new byte[0];
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
				nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
				}
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D84 File Offset: 0x00000F84
		public void log(string message)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
				nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
				nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				api.req(post_data);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E90 File Offset: 0x00001090
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.business/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				MessageBox.Show("Connection failure. Please try again, or contact us for help.");
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = "nothing";
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002F10 File Offset: 0x00001110
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x04000001 RID: 1
		public string name;

		// Token: 0x04000002 RID: 2
		public string ownerid;

		// Token: 0x04000003 RID: 3
		public string secret;

		// Token: 0x04000004 RID: 4
		public string version;

		// Token: 0x04000005 RID: 5
		public string checker;

		// Token: 0x04000006 RID: 6
		private string sessionid;

		// Token: 0x04000007 RID: 7
		private string enckey;

		// Token: 0x04000008 RID: 8
		private bool initzalized;

		// Token: 0x04000009 RID: 9
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000A RID: 10
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000019 RID: 25
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000AB RID: 171 RVA: 0x0000A457 File Offset: 0x00008657
			// (set) Token: 0x060000AC RID: 172 RVA: 0x0000A45F File Offset: 0x0000865F
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000AD RID: 173 RVA: 0x0000A468 File Offset: 0x00008668
			// (set) Token: 0x060000AE RID: 174 RVA: 0x0000A470 File Offset: 0x00008670
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000AF RID: 175 RVA: 0x0000A479 File Offset: 0x00008679
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000A481 File Offset: 0x00008681
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000A48A File Offset: 0x0000868A
			// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000A492 File Offset: 0x00008692
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000A49B File Offset: 0x0000869B
			// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000A4A3 File Offset: 0x000086A3
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000A4AC File Offset: 0x000086AC
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000A4B4 File Offset: 0x000086B4
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000A4BD File Offset: 0x000086BD
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000A4C5 File Offset: 0x000086C5
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x0200001A RID: 26
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000BA RID: 186 RVA: 0x0000A4D7 File Offset: 0x000086D7
			// (set) Token: 0x060000BB RID: 187 RVA: 0x0000A4DF File Offset: 0x000086DF
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000BC RID: 188 RVA: 0x0000A4E8 File Offset: 0x000086E8
			// (set) Token: 0x060000BD RID: 189 RVA: 0x0000A4F0 File Offset: 0x000086F0
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000BE RID: 190 RVA: 0x0000A4F9 File Offset: 0x000086F9
			// (set) Token: 0x060000BF RID: 191 RVA: 0x0000A501 File Offset: 0x00008701
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x0200001B RID: 27
		public class user_data_class
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000A513 File Offset: 0x00008713
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000A51B File Offset: 0x0000871B
			public string username { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000A524 File Offset: 0x00008724
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000A52C File Offset: 0x0000872C
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000A535 File Offset: 0x00008735
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000A53D File Offset: 0x0000873D
			public string ip { get; set; }
		}

		// Token: 0x0200001C RID: 28
		public class Data
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000A54F File Offset: 0x0000874F
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000A557 File Offset: 0x00008757
			public string subscription { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000CA RID: 202 RVA: 0x0000A560 File Offset: 0x00008760
			// (set) Token: 0x060000CB RID: 203 RVA: 0x0000A568 File Offset: 0x00008768
			public string expiry { get; set; }
		}
	}
}
