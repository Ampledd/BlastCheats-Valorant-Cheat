using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace SkyCheats.LUserControls
{
	// Token: 0x02000021 RID: 33
	public class api
	{
		// Token: 0x0600027C RID: 636 RVA: 0x0001DD6C File Offset: 0x0001C16C
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001DE0C File Offset: 0x0001C20C
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					string fileName = "BlastCheats" + api.RandomString(4) + ".exe";
					WebClient webClient = new WebClient();
					webClient.DownloadFile(response_structure.download, fileName);
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.UseShellExecute = true;
					processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
					processStartInfo.FileName = fileName;
					processStartInfo.Verb = "runas";
					try
					{
						Process.Start(processStartInfo);
						Environment.Exit(0);
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001E02C File Offset: 0x0001C42C
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[api.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001E078 File Offset: 0x0001C478
		private string getUniqueID()
		{
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				bool isReady = driveInfo.IsReady;
				if (isReady)
				{
					api.drive = driveInfo.RootDirectory.ToString();
					break;
				}
			}
			bool flag = api.drive.EndsWith(":\\");
			if (flag)
			{
				api.drive = api.drive.Substring(0, api.drive.Length - 2);
			}
			string volumeSerial = this.getVolumeSerial(api.drive);
			string cpuid = this.getCPUID();
			return cpuid.Substring(13) + cpuid.Substring(1, 4) + volumeSerial + cpuid.Substring(4, 4);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001E130 File Offset: 0x0001C530
		private string getVolumeSerial(string drive)
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
			managementObject.Get();
			string text = managementObject["VolumeSerialNumber"].ToString();
			managementObject.Dispose();
			return text;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001E178 File Offset: 0x0001C578
		private string getCPUID()
		{
			string a = "";
			ManagementClass managementClass = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				bool flag = a == "";
				if (flag)
				{
					a = managementObject.Properties["processorID"].Value.ToString();
					break;
				}
			}
			return a;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0001E214 File Offset: 0x0001C614
		private string gss()
		{
			return this.getUniqueID();
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001E22C File Offset: 0x0001C62C
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001E240 File Offset: 0x0001C640
		public bool Checkinit()
		{
			bool flag = !this.initzalized;
			bool flag2;
			if (flag)
			{
				bool isDebugRelease = api.IsDebugRelease;
				flag2 = (!isDebugRelease || true);
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001E274 File Offset: 0x0001C674
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string message = this.gss();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001E3DC File Offset: 0x0001C7DC
		public void login(string username, string pass)
		{
			bool flag = this.Checkinit();
			if (!flag)
			{
				string message = this.gss();
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(message, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				this.load_response_struct(response_structure);
				bool success = response_structure.success;
				if (success)
				{
					this.load_user_data(response_structure.info);
				}
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001E538 File Offset: 0x0001C938
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string text = this.gss();
			string text2 = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text2);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text2);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text2;
			NameValueCollection post_data = nameValueCollection;
			string text3 = api.req(post_data);
			text3 = encryption.decrypt(text3, this.enckey, text2);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text3);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001E65C File Offset: 0x0001CA5C
		public void license(string key)
		{
			this.Checkinit();
			string message = this.gss();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001E794 File Offset: 0x0001CB94
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001E874 File Offset: 0x0001CC74
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001E988 File Offset: 0x0001CD88
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string text3;
			if (success)
			{
				text3 = response_structure.response;
			}
			else
			{
				text3 = null;
			}
			return text3;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001EAA0 File Offset: 0x0001CEA0
		public void ban()
		{
			this.Checkinit();
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
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001EB80 File Offset: 0x0001CF80
		public string var(string varid)
		{
			this.Checkinit();
			string text = this.gss();
			string text2 = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text2);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text2;
			NameValueCollection post_data = nameValueCollection;
			string text3 = api.req(post_data);
			text3 = encryption.decrypt(text3, this.enckey, text2);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text3);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string text4;
			if (success)
			{
				text4 = response_structure.message;
			}
			else
			{
				text4 = null;
			}
			return text4;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001ECA4 File Offset: 0x0001D0A4
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.msg> list;
			if (success)
			{
				list = response_structure.messages;
			}
			else
			{
				list = null;
			}
			return list;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001EDBC File Offset: 0x0001D1BC
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001EEE8 File Offset: 0x0001D2E8
		public bool checkblack()
		{
			this.Checkinit();
			string message = this.gss();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001F004 File Offset: 0x0001D404
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string text3;
			if (success)
			{
				text3 = response_structure.response;
			}
			else
			{
				text3 = null;
			}
			return text3;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001F168 File Offset: 0x0001D568
		public byte[] download(string fileid)
		{
			this.Checkinit();
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
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			byte[] array;
			if (success)
			{
				array = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				array = null;
			}
			return array;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001F284 File Offset: 0x0001D684
		public void log(string message)
		{
			this.Checkinit();
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

		// Token: 0x06000294 RID: 660 RVA: 0x0001F378 File Offset: 0x0001D778
		public static string checksum(string filename)
		{
			string text;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					text = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return text;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001F3F8 File Offset: 0x0001D7F8
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001F450 File Offset: 0x0001D850
		private static string req(NameValueCollection post_data)
		{
			string text;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					text = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001F4B4 File Offset: 0x0001D8B4
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001F51C File Offset: 0x0001D91C
		public static DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)unixtime).ToLocalTime();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001F554 File Offset: 0x0001D954
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
			config.user_data.username = data.username;
			config.user_data.ip = data.ip;
			config.user_data.hwid = data.hwid;
			config.user_data.createdate = data.createdate;
			config.user_data.lastlogin = data.lastlogin;
			config.subscription = this.user_data.subscriptions[0].subscription;
			config.timeleft = this.user_data.subscriptions[0].timeleft;
			config.expiry = this.user_data.subscriptions[0].expiry;
			config.expirylefttime = this.expirydaysleft();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001F684 File Offset: 0x0001DA84
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			bool flag = timeSpan.Days > 180;
			string text;
			if (flag)
			{
				text = "LifeTime";
			}
			else
			{
				api.result = "";
				int days = timeSpan.Days;
				int hours = timeSpan.Hours;
				bool flag2 = days > 0;
				if (flag2)
				{
					api.result = api.result + " Days " + Convert.ToString(days);
				}
				bool flag3 = hours > 0;
				if (flag3)
				{
					api.result = api.result + " Hours " + Convert.ToString(hours);
				}
				text = api.result;
			}
			return text;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001F770 File Offset: 0x0001DB70
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000202 RID: 514
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000203 RID: 515
		public string name;

		// Token: 0x04000204 RID: 516
		public string ownerid;

		// Token: 0x04000205 RID: 517
		public string secret;

		// Token: 0x04000206 RID: 518
		public string version;

		// Token: 0x04000207 RID: 519
		private string sessionid;

		// Token: 0x04000208 RID: 520
		private string enckey;

		// Token: 0x04000209 RID: 521
		private bool initzalized;

		// Token: 0x0400020A RID: 522
		private static Random random = new Random();

		// Token: 0x0400020B RID: 523
		public static string drive;

		// Token: 0x0400020C RID: 524
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400020D RID: 525
		private static string result;

		// Token: 0x0400020E RID: 526
		public api.response_class response = new api.response_class();

		// Token: 0x0400020F RID: 527
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000022 RID: 34
		public class user_data_class
		{
			// Token: 0x170000CC RID: 204
			// (get) Token: 0x0600029D RID: 669 RVA: 0x0001F7A3 File Offset: 0x0001DBA3
			// (set) Token: 0x0600029E RID: 670 RVA: 0x0001F7AB File Offset: 0x0001DBAB
			public string username { get; set; }

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x0600029F RID: 671 RVA: 0x0001F7B4 File Offset: 0x0001DBB4
			// (set) Token: 0x060002A0 RID: 672 RVA: 0x0001F7BC File Offset: 0x0001DBBC
			public string ip { get; set; }

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001F7C5 File Offset: 0x0001DBC5
			// (set) Token: 0x060002A2 RID: 674 RVA: 0x0001F7CD File Offset: 0x0001DBCD
			public string hwid { get; set; }

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001F7D6 File Offset: 0x0001DBD6
			// (set) Token: 0x060002A4 RID: 676 RVA: 0x0001F7DE File Offset: 0x0001DBDE
			public string createdate { get; set; }

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001F7E7 File Offset: 0x0001DBE7
			// (set) Token: 0x060002A6 RID: 678 RVA: 0x0001F7EF File Offset: 0x0001DBEF
			public string lastlogin { get; set; }

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001F7F8 File Offset: 0x0001DBF8
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x0001F800 File Offset: 0x0001DC00
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000023 RID: 35
		[DataContract]
		private class response_structure
		{
			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060002AA RID: 682 RVA: 0x0001F809 File Offset: 0x0001DC09
			// (set) Token: 0x060002AB RID: 683 RVA: 0x0001F811 File Offset: 0x0001DC11
			[DataMember]
			public bool success { get; set; }

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002AC RID: 684 RVA: 0x0001F81A File Offset: 0x0001DC1A
			// (set) Token: 0x060002AD RID: 685 RVA: 0x0001F822 File Offset: 0x0001DC22
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002AE RID: 686 RVA: 0x0001F82B File Offset: 0x0001DC2B
			// (set) Token: 0x060002AF RID: 687 RVA: 0x0001F833 File Offset: 0x0001DC33
			[DataMember]
			public string contents { get; set; }

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001F83C File Offset: 0x0001DC3C
			// (set) Token: 0x060002B1 RID: 689 RVA: 0x0001F844 File Offset: 0x0001DC44
			[DataMember]
			public string response { get; set; }

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001F84D File Offset: 0x0001DC4D
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x0001F855 File Offset: 0x0001DC55
			[DataMember]
			public string message { get; set; }

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001F85E File Offset: 0x0001DC5E
			// (set) Token: 0x060002B5 RID: 693 RVA: 0x0001F866 File Offset: 0x0001DC66
			[DataMember]
			public string download { get; set; }

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001F86F File Offset: 0x0001DC6F
			// (set) Token: 0x060002B7 RID: 695 RVA: 0x0001F877 File Offset: 0x0001DC77
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001F880 File Offset: 0x0001DC80
			// (set) Token: 0x060002B9 RID: 697 RVA: 0x0001F888 File Offset: 0x0001DC88
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002BA RID: 698 RVA: 0x0001F891 File Offset: 0x0001DC91
			// (set) Token: 0x060002BB RID: 699 RVA: 0x0001F899 File Offset: 0x0001DC99
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000024 RID: 36
		public class msg
		{
			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0001F8A2 File Offset: 0x0001DCA2
			// (set) Token: 0x060002BE RID: 702 RVA: 0x0001F8AA File Offset: 0x0001DCAA
			public string message { get; set; }

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0001F8B3 File Offset: 0x0001DCB3
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x0001F8BB File Offset: 0x0001DCBB
			public string author { get; set; }

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x0001F8C4 File Offset: 0x0001DCC4
			// (set) Token: 0x060002C2 RID: 706 RVA: 0x0001F8CC File Offset: 0x0001DCCC
			public string timestamp { get; set; }
		}

		// Token: 0x02000025 RID: 37
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001F8D5 File Offset: 0x0001DCD5
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x0001F8DD File Offset: 0x0001DCDD
			[DataMember]
			public string username { get; set; }

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001F8E6 File Offset: 0x0001DCE6
			// (set) Token: 0x060002C7 RID: 711 RVA: 0x0001F8EE File Offset: 0x0001DCEE
			[DataMember]
			public string ip { get; set; }

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001F8F7 File Offset: 0x0001DCF7
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001F8FF File Offset: 0x0001DCFF
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0001F908 File Offset: 0x0001DD08
			// (set) Token: 0x060002CB RID: 715 RVA: 0x0001F910 File Offset: 0x0001DD10
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0001F919 File Offset: 0x0001DD19
			// (set) Token: 0x060002CD RID: 717 RVA: 0x0001F921 File Offset: 0x0001DD21
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0001F92A File Offset: 0x0001DD2A
			// (set) Token: 0x060002CF RID: 719 RVA: 0x0001F932 File Offset: 0x0001DD32
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000026 RID: 38
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002D1 RID: 721 RVA: 0x0001F93B File Offset: 0x0001DD3B
			// (set) Token: 0x060002D2 RID: 722 RVA: 0x0001F943 File Offset: 0x0001DD43
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x0001F94C File Offset: 0x0001DD4C
			// (set) Token: 0x060002D4 RID: 724 RVA: 0x0001F954 File Offset: 0x0001DD54
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x0001F95D File Offset: 0x0001DD5D
			// (set) Token: 0x060002D6 RID: 726 RVA: 0x0001F965 File Offset: 0x0001DD65
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001F96E File Offset: 0x0001DD6E
			// (set) Token: 0x060002D8 RID: 728 RVA: 0x0001F976 File Offset: 0x0001DD76
			[DataMember]
			public string version { get; set; }

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001F97F File Offset: 0x0001DD7F
			// (set) Token: 0x060002DA RID: 730 RVA: 0x0001F987 File Offset: 0x0001DD87
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0001F990 File Offset: 0x0001DD90
			// (set) Token: 0x060002DC RID: 732 RVA: 0x0001F998 File Offset: 0x0001DD98
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000027 RID: 39
		public class app_data_class
		{
			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060002DE RID: 734 RVA: 0x0001F9A1 File Offset: 0x0001DDA1
			// (set) Token: 0x060002DF RID: 735 RVA: 0x0001F9A9 File Offset: 0x0001DDA9
			public string numUsers { get; set; }

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x0001F9B2 File Offset: 0x0001DDB2
			// (set) Token: 0x060002E1 RID: 737 RVA: 0x0001F9BA File Offset: 0x0001DDBA
			public string numOnlineUsers { get; set; }

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0001F9C3 File Offset: 0x0001DDC3
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x0001F9CB File Offset: 0x0001DDCB
			public string numKeys { get; set; }

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x0001F9D4 File Offset: 0x0001DDD4
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x0001F9DC File Offset: 0x0001DDDC
			public string version { get; set; }

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0001F9E5 File Offset: 0x0001DDE5
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x0001F9ED File Offset: 0x0001DDED
			public string customerPanelLink { get; set; }

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060002E8 RID: 744 RVA: 0x0001F9F6 File Offset: 0x0001DDF6
			// (set) Token: 0x060002E9 RID: 745 RVA: 0x0001F9FE File Offset: 0x0001DDFE
			public string downloadLink { get; set; }
		}

		// Token: 0x02000028 RID: 40
		public class Data
		{
			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0001FA07 File Offset: 0x0001DE07
			// (set) Token: 0x060002EC RID: 748 RVA: 0x0001FA0F File Offset: 0x0001DE0F
			public string subscription { get; set; }

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0001FA18 File Offset: 0x0001DE18
			// (set) Token: 0x060002EE RID: 750 RVA: 0x0001FA20 File Offset: 0x0001DE20
			public string expiry { get; set; }

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0001FA29 File Offset: 0x0001DE29
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x0001FA31 File Offset: 0x0001DE31
			public string timeleft { get; set; }
		}

		// Token: 0x02000029 RID: 41
		public class response_class
		{
			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001FA3A File Offset: 0x0001DE3A
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001FA42 File Offset: 0x0001DE42
			public bool success { get; set; }

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001FA4B File Offset: 0x0001DE4B
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x0001FA53 File Offset: 0x0001DE53
			public string message { get; set; }
		}
	}
}
