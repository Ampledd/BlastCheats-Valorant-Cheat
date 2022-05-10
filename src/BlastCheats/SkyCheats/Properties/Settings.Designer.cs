using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SkyCheats.Properties
{
	// Token: 0x02000020 RID: 32
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001DD34 File Offset: 0x0001C134
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000201 RID: 513
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
