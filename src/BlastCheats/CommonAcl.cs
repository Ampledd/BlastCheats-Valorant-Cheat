using System;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.Win32;

// Token: 0x02000002 RID: 2
internal class CommonAcl
{
	// Token: 0x06000003 RID: 3
	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
	private static extern IntPtr GenericAcl(string lpModuleName);

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
	private static extern IntPtr TryCode(IntPtr hModule, string procName);

	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetFileAttributes", SetLastError = true)]
	private static extern uint ISymbolReader(string lpFileName);

	// Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000458
	internal static bool SecurityDocumentElement()
	{
		bool flag = !CommonAcl.MessageDictionary();
		return !flag;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000207C File Offset: 0x0000047C
	private static bool MessageDictionary()
	{
		bool flag = CommonAcl.SoapNcName("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VBOX") || CommonAcl.SoapNcName("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("VBOX") || CommonAcl.SoapNcName("HARDWARE\\Description\\System", "VideoBiosVersion").ToUpper().Contains("VIRTUALBOX") || CommonAcl.SoapNcName("SOFTWARE\\Oracle\\VirtualBox Guest Additions", "") == "noValueButYesKey" || CommonAcl.ISymbolReader("C:\\WINDOWS\\system32\\drivers\\VBoxMouse.sys") != uint.MaxValue || CommonAcl.SoapNcName("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE") || CommonAcl.SoapNcName("SOFTWARE\\VMware, Inc.\\VMware Tools", "") == "noValueButYesKey" || CommonAcl.SoapNcName("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 1\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE") || CommonAcl.SoapNcName("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 2\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE") || CommonAcl.SoapNcName("SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0").ToUpper().Contains("vmware".ToUpper()) || CommonAcl.SoapNcName("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "DriverDesc").ToUpper().Contains("VMWARE") || CommonAcl.SoapNcName("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000\\Settings", "Device Description").ToUpper().Contains("VMWARE") || CommonAcl.SoapNcName("SOFTWARE\\VMware, Inc.\\VMware Tools", "InstallPath").ToUpper().Contains("C:\\PROGRAM FILES\\VMWARE\\VMWARE TOOLS\\") || CommonAcl.ISymbolReader("C:\\WINDOWS\\system32\\drivers\\vmmouse.sys") != uint.MaxValue || CommonAcl.ISymbolReader("C:\\WINDOWS\\system32\\drivers\\vmhgfs.sys") != uint.MaxValue || CommonAcl.TryCode(CommonAcl.GenericAcl("kernel32.dll"), "wine_get_unix_file_name") != (IntPtr)0 || CommonAcl.SoapNcName("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("QEMU") || CommonAcl.SoapNcName("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("QEMU");
		bool result;
		if (flag)
		{
			result = true;
		}
		else
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ManagementScope("\\\\.\\ROOT\\cimv2"), new ObjectQuery("SELECT * FROM Win32_VideoController")).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				bool flag2 = managementObject["Description"].ToString() == "VM Additions S3 Trio32/64" || managementObject["Description"].ToString() == "S3 Trio32/64" || managementObject["Description"].ToString() == "VirtualBox Graphics Adapter" || managementObject["Description"].ToString() == "VMware SVGA II" || managementObject["Description"].ToString().ToUpper().Contains("VMWARE") || managementObject["Description"].ToString() == "";
				if (flag2)
				{
					return true;
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000023E8 File Offset: 0x000007E8
	private static string SoapNcName([In] string obj0, [In] string obj1)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(obj0, false);
		bool flag = registryKey == null;
		string result;
		if (flag)
		{
			result = "noKey";
		}
		else
		{
			object value = registryKey.GetValue(obj1, "noValueButYesKey");
			bool flag2 = value is string || registryKey.GetValueKind(obj1) == RegistryValueKind.String || registryKey.GetValueKind(obj1) == RegistryValueKind.ExpandString;
			if (flag2)
			{
				result = value.ToString();
			}
			else
			{
				bool flag3 = registryKey.GetValueKind(obj1) == RegistryValueKind.DWord;
				if (flag3)
				{
					result = Convert.ToString((int)value);
				}
				else
				{
					bool flag4 = registryKey.GetValueKind(obj1) == RegistryValueKind.QWord;
					if (flag4)
					{
						result = Convert.ToString((long)value);
					}
					else
					{
						bool flag5 = registryKey.GetValueKind(obj1) == RegistryValueKind.Binary;
						if (flag5)
						{
							result = Convert.ToString((byte[])value);
						}
						else
						{
							bool flag6 = registryKey.GetValueKind(obj1) == RegistryValueKind.MultiString;
							if (flag6)
							{
								result = string.Join("", (string[])value);
							}
							else
							{
								result = "noValueButYesKey";
							}
						}
					}
				}
			}
		}
		return result;
	}
}
